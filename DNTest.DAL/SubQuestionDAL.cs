using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNTest.Entity;
using System.Data;
using System.Data.SqlClient;

namespace DNTest.DAL
{
    public class SubQuestionDAL : SqlDataProvider
    {
        public List<SubQuestion> SubQuestion_GetByTop(string Top, string Where, string Order)
        {
            List<SubQuestion> list = new List<SubQuestion>();
            using (SqlCommand dbCmd = new SqlCommand("sp_SubQuestion_getByTop", openConnection()))
            {
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@Top", Top));
                dbCmd.Parameters.Add(new SqlParameter("@Where", Where));
                dbCmd.Parameters.Add(new SqlParameter("@Order", Order));
                SqlDataReader dr = dbCmd.ExecuteReader();
                dr.Close();
                dr = dbCmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        SubQuestion obj = new SubQuestion();
                        obj.SubQuestionIDataReader(dr);
                        list.Add(obj);
                    }
                }
                dr.Close();
            }
            return list;
        }
        public int SubQuestion_Insert(SubQuestion data)
        {
            int id = -1;

            using (SqlCommand dbCmd = new SqlCommand("sp_SubQuestion_Insert", openConnection()))
            {
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.Parameters.Add(new SqlParameter("@questionID", data.QuestionId));
                dbCmd.Parameters.Add(new SqlParameter("@content", data.Content));
                //    dbCmd.Parameters.Add(new SqlParameter("@active", data.Active));
                dbCmd.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;
                dbCmd.ExecuteNonQuery();
                id = int.Parse(dbCmd.Parameters["@id"].Value.ToString());
            }

            return id;
        }

        public bool SubQuestion_Update(SubQuestion data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_SubQuestion_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@id", data.Id));
                    dbCmd.Parameters.Add(new SqlParameter("@questionID", data.QuestionId));
                    dbCmd.Parameters.Add(new SqlParameter("@content", data.Content));
                  //  dbCmd.Parameters.Add(new SqlParameter("@active", data.Active));
                  //  dbCmd.Parameters.Add(new SqlParameter("@reportCount", data.ReportCount));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

        public bool SubQuestion_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_SubQuestion_Delete", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@id", ID));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }
    }
}