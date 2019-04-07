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
    public class StudentDB
    {
        public bool StudentAdd(Student s)
        {
            int count = DataAccess.ExecuteNonQuery("spStudentInsert", System.Data.CommandType.StoredProcedure, BuildParams(s));
            if (count > 0)
                return true;
            return false;
        }
        public bool StudentUpdate(Student s)
        {
            int count = DataAccess.ExecuteNonQuery("spStudentUpdate", System.Data.CommandType.StoredProcedure, BuildParams(s));
            if (count > 0)
                return true;
            else
                return false;
        }
        public bool StudentDelete(string id)
        {
            List<ParamStruct> pa = new List<ParamStruct>()
            {
                new ParamStruct("@id", id, SqlDbType.NChar, ParameterDirection.Input, 8)
            };

            int count = DataAccess.ExecuteNonQuery("spStudentDelete", CommandType.StoredProcedure, pa);
            if (count > 0)
                return true;
            else
                return false;
        }
        public Student StudentRetrieve(string id)
        {
            List<ParamStruct> pa = new List<ParamStruct>();
            pa.Add(new ParamStruct("@Id", id, System.Data.SqlDbType.NChar, System.Data.ParameterDirection.Input, 8));
            DataTable dt = DataAccess.Execute("spStudentRetrieve", CommandType.StoredProcedure, pa);
            return BuildStudent(dt);
        }
        public List<Student> StudentsSearch(string key)
        {
            List<ParamStruct> pa = new List<ParamStruct>();
            pa.Add(new ParamStruct("@Key", key, SqlDbType.VarChar, ParameterDirection.Input, 50));
            return BuildStudents(DataAccess.Execute("spStudentSearch", CommandType.StoredProcedure, pa));
        }
        public Student StudentByResource(string key)
        {
            List<ParamStruct> pa = new List<ParamStruct>()
          {
              new ParamStruct("@ResourceId", key, SqlDbType.NChar, ParameterDirection.Input, 8)
        };
            return BuildStudent(DataAccess.Execute("spRetrieveStudentByResource", CommandType.StoredProcedure, pa));
        }
        

        private List<Student> BuildStudents(DataTable dt)
        {
            List<Student> students = new List<Student>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                Student s = new Student();
                s.Id = dt.Rows[i]["ID"].ToString();
                s.FirstName = dt.Rows[i]["Fname"].ToString();
                s.LastName = dt.Rows[i]["Lname"].ToString();
                s.Program = dt.Rows[i]["Program"].ToString();
                //object a = Convert.ToInt16( dt.Rows[i]["Status"]);
                s.Status = (StudentStatus)(Convert.ToInt16(dt.Rows[i]["Status"]));
                s.StartDate = (DateTime)dt.Rows[i]["StartDate"];
                s.EndDate = (DateTime)dt.Rows[i]["EndDate"];
                s.BalanceDue = Convert.ToDouble(dt.Rows[i]["BalanceDue"]);
                s.Address = dt.Rows[i]["Address"].ToString();
                s.City = dt.Rows[i]["City"].ToString();
                s.PostalCode = dt.Rows[i]["PostalCode"].ToString();
                s.PhoneNumber = dt.Rows[i]["PhoneNumber"].ToString();
                students.Add(s);
            }
            return students;
        }
        private Student BuildStudent(DataTable dt)
        {
            Student s = new Student();
            s.Id = dt.Rows[0]["ID"].ToString();
            s.FirstName = dt.Rows[0]["Fname"].ToString();
            s.LastName = dt.Rows[0]["Lname"].ToString();
            s.Program = dt.Rows[0]["Program"].ToString();
            s.Status = (StudentStatus)(Convert.ToInt16(dt.Rows[0]["Status"]));
            s.StartDate = (DateTime)dt.Rows[0]["StartDate"];
            s.EndDate = (DateTime)dt.Rows[0]["EndDate"];
            s.BalanceDue = Convert.ToDouble(dt.Rows[0]["BalanceDue"]);
            s.Address = dt.Rows[0]["Address"].ToString();
            s.City = dt.Rows[0]["City"].ToString();
            s.PostalCode = dt.Rows[0]["PostalCode"].ToString();
            s.PhoneNumber = dt.Rows[0]["PhoneNumber"].ToString();
            return s;
        }
        private List<ParamStruct> BuildParams(Student s)
        {
            List<ParamStruct> pa = new List<ParamStruct>();
            if (!String.IsNullOrEmpty(s.Id))
                pa.Add(new ParamStruct("@id", s.Id, System.Data.SqlDbType.NChar, System.Data.ParameterDirection.Input, 8));
            pa.Add(new ParamStruct("@fname", s.FirstName, System.Data.SqlDbType.NVarChar, System.Data.ParameterDirection.Input, 50));
            pa.Add(new ParamStruct("@lname", s.LastName, System.Data.SqlDbType.NVarChar, System.Data.ParameterDirection.Input, 50));
            pa.Add(new ParamStruct("@program", s.Program, System.Data.SqlDbType.Char, System.Data.ParameterDirection.Input, 3));
            pa.Add(new ParamStruct("@startdate", s.StartDate, System.Data.SqlDbType.Date, System.Data.ParameterDirection.Input));
            pa.Add(new ParamStruct("@enddate", s.EndDate, System.Data.SqlDbType.Date, System.Data.ParameterDirection.Input));
            pa.Add(new ParamStruct("@status", s.Status, System.Data.SqlDbType.Bit, System.Data.ParameterDirection.Input));
            pa.Add(new ParamStruct("@balancedue", s.BalanceDue, System.Data.SqlDbType.Money, System.Data.ParameterDirection.Input));
            pa.Add(new ParamStruct("@address", s.Address, SqlDbType.VarChar, ParameterDirection.Input, 256));
            pa.Add(new ParamStruct("@city", s.City, SqlDbType.VarChar, ParameterDirection.Input, 50));
            pa.Add(new ParamStruct("@postalcode", s.PostalCode, SqlDbType.NChar, ParameterDirection.Input, 8));
            pa.Add(new ParamStruct("@phonenumber", s.PhoneNumber, SqlDbType.NChar, ParameterDirection.Input, 11));
            return pa;
        }
    }
}
