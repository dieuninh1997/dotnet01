using DNTest.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNTest.DAL
{
    public class TeacherDAL: SqlDataProvider
    {
        public void Update_Password(Teacher data)
        {
          using (SqlCommand dbCmd = new SqlCommand("sp_Teacher_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@id", data.Id));
                    dbCmd.Parameters.Add(new SqlParameter("@name", data.Name));
                    dbCmd.Parameters.Add(new SqlParameter("@username", data.User));
                    dbCmd.Parameters.Add(new SqlParameter("@password", data.Password));
                    dbCmd.Parameters.Add(new SqlParameter("@avatar", data.Avatar));
                    int r = dbCmd.ExecuteNonQuery();
                }
        }
    }
}
