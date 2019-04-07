using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace SQL
{
    public class LoanDB
    {
        public Loan RetrieveLoan(int Id)
        {
            List<ParamStruct> pa = new List<ParamStruct>();
            pa.Add(new ParamStruct("@id", Id, SqlDbType.Int, ParameterDirection.Input));
            DataTable dt = DataAccess.Execute("spLoanRetrieve", CommandType.StoredProcedure, pa);
            if (dt.Rows.Count > 0)
                return BildLoan(dt.Rows[0]);
            return new Loan();          //Exception code goes here
        }

        public int CheckResourceType(ResourseType type, string StudentId)
        {
            List<ParamStruct> pa = new List<ParamStruct>()
            {
                new ParamStruct("@StudentId", StudentId, SqlDbType.NChar, ParameterDirection.Input, 8),
                new ParamStruct("@ResourceType", (int)type, SqlDbType.TinyInt, ParameterDirection.Input)
            };
        return Convert.ToInt32( DataAccess.ExecuteScalar("spResourceTypeCheck", CommandType.StoredProcedure, pa));
        }

        public int CreateLoan(Student s, DateTime DueDate, DateTime CheckInDate)
        {
            List<ParamStruct> pa = new List<ParamStruct>
            {
                new ParamStruct("@CheckOut", CheckInDate, SqlDbType.Date, ParameterDirection.Input),
                new ParamStruct("@DueDate", DueDate, SqlDbType.Date, ParameterDirection.Input),
                new ParamStruct("@StudentId", s.Id, SqlDbType.NChar, ParameterDirection.Input, 8)
            };
            return Convert.ToInt32(DataAccess.ExecuteScalar("spLoanCreate", CommandType.StoredProcedure, pa));
        }
        public bool AddToLoan(string resource, int loan)
        {
            List<ParamStruct> pa = new List<ParamStruct>()
            {
                new ParamStruct("@LoanID", loan, SqlDbType.Int, ParameterDirection.Input),
                new ParamStruct("@ResourceID", resource, SqlDbType.NChar, ParameterDirection.Input, 8),
            };
            int res = DataAccess.ExecuteNonQuery("spAddToLoan", CommandType.StoredProcedure, pa);
            return res > 0;
        }
        public Loan GetLoanByResource(string resource)
        {
            List<ParamStruct> pa = new List<ParamStruct>()
            {
                new ParamStruct("@ResourceID", resource, SqlDbType.NChar, ParameterDirection.Input, 8)
            };
            return BildLoan((DataAccess.Execute("spGetLoanByResource", CommandType.StoredProcedure, pa)).Rows[0]);
        }


        private Loan BildLoan(DataRow dr)
        {
            ResourceDB r = new ResourceDB();
            StudentDB s = new StudentDB();
            Loan loan = new Loan();
            if (dr["ID"] != null)
                loan.Id = (int)dr["ID"];
            loan.CheckOutDate = (DateTime)dr["CheckOutDate"];
            loan.DueDate = (DateTime)dr["DueDate"];
            loan.Resource = r.GetResourcesByLoan(Convert.ToInt32(dr["ID"]));
            loan.Student = s.StudentRetrieve(dr["StudentId"].ToString());
            return loan;
        }
        
    }
}
