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
        private string questionID;
        private string answer;
        private string isCorrect;

        public Answer(string id, string questionID, string answer, string isCorrect)
        {
            this.id = id;
            this.questionID = questionID;
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

        public string QuestionID
        {
            get
            {
                return questionID;
            }

            set
            {
                questionID = value;
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
            QuestionID = dr["questionID"] is DBNull ? string.Empty : dr["questionID"].ToString();
            Answers = dr["answer"] is DBNull ? string.Empty : dr["answer"].ToString();
            IsCorrect = dr["isCorrect"] is DBNull ? "" : dr["isCorrect"].ToString();
        }
    }
}
