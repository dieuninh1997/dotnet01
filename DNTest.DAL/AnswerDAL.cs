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
    public class AnswerDAL : SqlDataProvider
    {
        public List<Answer> Answer_GetByTop(string Top, string Where, string Order)
        {
            List<Answer> list = new List<Answer>();
            using (SqlCommand dbCmd = new SqlCommand("sp_Answer_getByTop", openConnection()))
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
                        Answer obj = new Answer();
                        obj.AnswerIDataReader(dr);
                        list.Add(obj);
                    }
                }
                dr.Close();
            }
            return list;
        }
        public bool Answer_Insert(Answer data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Answer_Insert", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@questionID", data.QuestionID));
                    dbCmd.Parameters.Add(new SqlParameter("@answer", data.Answers));
                    dbCmd.Parameters.Add(new SqlParameter("@isCorrect", data.IsCorrect));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

        public bool Answer_Update(Answer data)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Answer_Update", openConnection()))
                {
                    dbCmd.CommandType = CommandType.StoredProcedure;
                    dbCmd.Parameters.Add(new SqlParameter("@id", data.Id));
                    dbCmd.Parameters.Add(new SqlParameter("@questionID", data.QuestionID));
                    dbCmd.Parameters.Add(new SqlParameter("@answer", data.Answers));
                    dbCmd.Parameters.Add(new SqlParameter("@isCorrect", data.IsCorrect));
                    int r = dbCmd.ExecuteNonQuery();
                    if (r > 0) check = true;
                }
            }
            catch
            {
            }
            return check;
        }

        public bool Answer_Delete(string ID)
        {
            bool check = false;
            try
            {
                using (SqlCommand dbCmd = new SqlCommand("sp_Answer_Delete", openConnection()))
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
