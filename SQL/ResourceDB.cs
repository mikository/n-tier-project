using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace SQL
{
    public class ResourceDB
    {
        public Resource ResourceRetrieve(string id)
        {
            List<ParamStruct> pa = new List<ParamStruct>();
            pa.Add(new ParamStruct("@ID", id, SqlDbType.NChar, ParameterDirection.Input, 8));
            return BuildResource(DataAccess.Execute("spResourceRetrieve", CommandType.StoredProcedure, pa).Rows[0]);
        }
        public List<Resource> ResourceSearch(int id)
        {
            List<ParamStruct> pa = new List<ParamStruct>();
            pa.Add(new ParamStruct("@ID", id, SqlDbType.Int, ParameterDirection.Input));
            return BuildResources(DataAccess.Execute("spResourceSearch", CommandType.StoredProcedure, pa));
        }
        public bool ReserveResource(string rID, string sID)
        {
            List<ParamStruct> pa = new List<ParamStruct>();
            pa.Add(new ParamStruct("@id", rID, SqlDbType.NChar, ParameterDirection.Input, 8));
            pa.Add(new ParamStruct("@Studentid", sID, SqlDbType.NChar, ParameterDirection.Input, 8));
            int count = DataAccess.ExecuteNonQuery("spResourceReserve", CommandType.StoredProcedure, pa);
            if (count > 0)
                return true;
            else
                return false;
        }
        public List<Resource> GetResourcesByStudent(string id)
        {
            List<ParamStruct> pa = new List<ParamStruct>();
            pa.Add(new ParamStruct("@StudentID", id, SqlDbType.NChar, ParameterDirection.Input, 8));
            List<Resource> result = BuildResources(DataAccess.Execute("spRetrieveResourcesByStudent", CommandType.StoredProcedure, pa));
            return result;
        }
        public List<Resource> GetResourcesByLoan(int id)
        {
            List<ParamStruct> pa = new List<ParamStruct>()
            {
                new ParamStruct("@LoanId", id, SqlDbType.Int, ParameterDirection.Input)
            };
            return BuildResources(DataAccess.Execute("spResourceRetrieveByLoan", CommandType.StoredProcedure, pa));
        }
        public bool ReturnResource(string id, DateTime date, int status)
        {
            List<ParamStruct> pa = new List<ParamStruct>()
            {
                new ParamStruct("@ResourceId", id, SqlDbType.NChar, ParameterDirection.Input, 8),
                new ParamStruct("@ReturnDate", date, SqlDbType.Date, ParameterDirection.Input),
                new ParamStruct("@ResourceStatus", status, SqlDbType.TinyInt, ParameterDirection.Input)
            };
            if (DataAccess.ExecuteNonQuery("spResourceReturn", CommandType.StoredProcedure, pa) > 1)
            {
                return true;
            }



            return false ;
        }
        public bool ResourceInsert(Resource r)
        {
            List<ParamStruct> pa = new List<ParamStruct>()
            {
                new ParamStruct("@id", r.Id, SqlDbType.NChar, ParameterDirection.Input, 8),
                new ParamStruct("@title", r.Title, SqlDbType.VarChar, ParameterDirection.Input, 50),
                 new ParamStruct("@type",  r.Type, SqlDbType.TinyInt, ParameterDirection.Input),
                 new ParamStruct("@status", r.Status, SqlDbType.TinyInt, ParameterDirection.Input),
                 new ParamStruct("@description", r.Description, SqlDbType.Text, ParameterDirection.Input),
                 new ParamStruct("@price", r.Price, SqlDbType.Money, ParameterDirection.Input)
            };
            if (DataAccess.ExecuteNonQuery("spResourceInsert", CommandType.StoredProcedure, pa) > 0)
                return true;
            return false;
        }
        public string getMaxId()
        {
            return DataAccess.ExecuteScalar("spResourceGetMaxId", CommandType.StoredProcedure).ToString();
        }

        private Resource BuildResource(DataRow dr)
        {
            Resource r = new Resource();
            r.Id = dr["ID"].ToString();
            //byte[] img = (byte[])dr["Image"];
            //MemoryStream ms = new MemoryStream(img);
            //r.Image = new Bitmap(ms);
            r.Price = Convert.ToDouble(dr["Price"]);
            r.Status = (ResourceStatus)(Convert.ToInt32(dr["Status"]));
            r.Title = dr["Title"].ToString();
            r.Type = (ResourseType)(Convert.ToInt32(dr["Type"]));
            r.DatePurchased = (DateTime)dr["DatePurchased"];
            if (DBNull.Value.Equals(dr["DateRemoved"] is null))
                r.DateRemoved = (DateTime)dr["DateRemoved"];
            r.Description = dr["Description"].ToString();
            return r;
        }
        private List<Resource> BuildResources(DataTable dt)
        {
            List<Resource> re = new List<Resource>();
            foreach(DataRow dr in dt.Rows)
            {
                Resource r = new Resource();
                r.Id = dr["ID"].ToString();
                //byte[] img = (byte[])dr["Image"];
                //MemoryStream ms = new MemoryStream(img);
                //r.Image = new Bitmap(ms);
                r.Price = Convert.ToDouble(dr["Price"]);
                r.Status = (ResourceStatus)(Convert.ToInt32(dr["Status"]));
                r.Title = dr["Title"].ToString();
                r.Type = (ResourseType)(Convert.ToInt32(dr["Type"]));
                r.DatePurchased = (DateTime)dr["DatePurchased"];
                if(DBNull.Value.Equals(dr["DateRemoved"] is null))
                    r.DateRemoved = (DateTime)dr["DateRemoved"];
                r.Description = dr["Description"].ToString();
                re.Add(r);
            }
            return re;
        }

    }
}
