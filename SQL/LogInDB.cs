using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace SQL
{
    public class LogInDB
    {
        public string Message = "";
        public int LogIn(string username, string password)
        {
            try
            {
                List<ParamStruct> pa = new List<ParamStruct>
                {
                    new ParamStruct("@Username", username, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input, 50),
                    new ParamStruct("@Password", password, System.Data.SqlDbType.VarChar, System.Data.ParameterDirection.Input, 20)
                };
                
                return Convert.ToInt32(DataAccess.ExecuteScalar("spLogIn", System.Data.CommandType.StoredProcedure, pa));
            }
            catch (SqlException ex)
            {
                Message = ex.Message;
                return 0;
            }

        }
    }
}
