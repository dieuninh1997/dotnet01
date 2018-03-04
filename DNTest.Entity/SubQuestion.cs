using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DNTest.Entity
{
    public class SubQuestion
    {
        private String id;
        private String questionID;
        private String content;
       // private String reportCount;
      //  private String active;

        public SubQuestion()
        {
        }

        public SubQuestion(string id, string questionId, string content/*, string active*/)
        {
            this.id = id;
            questionID = questionId;
            this.content = content;

          //  this.active = active;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string QuestionId
        {
            get { return questionID; }
            set { questionID = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        /*   public string ReportCount
       {
           get { return reportCount; }
           set { reportCount = value; }
       }

   public string Active
       {
           get { return active; }
           set { active = value; }
       }
       */

        public void SubQuestionIDataReader(SqlDataReader dr)
        {
            Id = dr["id"] is DBNull ? string.Empty : dr["id"].ToString();
            QuestionId = dr["questionID"] is DBNull ? string.Empty : dr["questionID"].ToString();
            Content = dr["content"] is DBNull ? "" : dr["content"].ToString();
           // ReportCount = dr["reportCount"] is DBNull ? "0" : dr["reportCount"].ToString();
          //  Active = dr["active"] is DBNull ? "" : dr["active"].ToString();
        }
    }
}

