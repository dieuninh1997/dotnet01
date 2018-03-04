using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DNTest.Entity
{
    public class Answer
    {
        private string id;
        private string subQuestionID;
        private string answer;
        private string isCorrect;

        public Answer(string id, string subQuestionID, string answer, string isCorrect)
        {
            this.id = id;
            this.subQuestionID = subQuestionID;
            this.answer = answer;
            this.isCorrect = isCorrect;
        }

        public Answer()
        {
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string SubQuestionID
        {
            get
            {
                return subQuestionID;
            }

            set
            {
                subQuestionID = value;
            }
        }


        public string Answers
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }

        public string IsCorrect
        {
            get
            {
                return isCorrect;
            }

            set
            {
                isCorrect = value;
            }
        }
  
        public void AnswerIDataReader(SqlDataReader dr)
        {
            Id = dr["id"] is DBNull ? string.Empty : dr["id"].ToString();
            SubQuestionID = dr["subQuestionID"] is DBNull ? string.Empty : dr["subQuestionID"].ToString();
            Answers = dr["answer"] is DBNull ? string.Empty : dr["answer"].ToString();
            IsCorrect = dr["isCorrect"] is DBNull ? "" : dr["isCorrect"].ToString();
        }
    }
}
