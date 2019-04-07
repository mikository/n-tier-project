using DAL.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace DAL
{
    public class DataAccess
    {
        public static DataTable Execute(string cmdText, CommandType cmdType, List<ParamStruct> parms)
        {
            SqlCommand cmd = CreateCommand(cmdText, cmdType, parms);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }
        public static int ExecuteNonQuery(string cmdText, CommandType cmdType, List<ParamStruct> parms)
        {
            SqlCommand cmd = CreateCommand(cmdText, cmdType, parms);

            using (cmd.Connection)
            {
                cmd.Connection.Open();
                return cmd.ExecuteNonQuery();
            }
        }
        public static object ExecuteScalar(string sql, CommandType cmdType, List<ParamStruct> parms = null)
        {
            SqlCommand cmd = CreateCommand(sql, cmdType, parms);
            cmd.Connection.Open();
            object retVal = cmd.ExecuteScalar();
            cmd.Connection.Close();
            return retVal;
        }
        private static SqlCommand CreateCommand(string cmdText, CommandType cmdType, List<ParamStruct> parms)
        {
            SqlConnection conn = new SqlConnection(Settings.Default.cnn);

            SqlCommand cmd = new SqlCommand(cmdText, conn);
            cmd.CommandType = cmdType;

            if (parms != null)
            {
                foreach (ParamStruct p in parms)
                {
                    SqlParameter pa = new SqlParameter(p.name, p.type, p.size);
                    pa.Value = p.value;
                    pa.Direction = p.direction;
                    cmd.Parameters.Add(pa);
                }
            }

            return cmd;
        }
    }
}
