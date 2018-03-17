using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DNTest.Entity
{
    public class Quiz
    {
        private string id;
        private string subjectID;
        private string quizName;
        private string questionCount;
        private string time;
        private string questionList;
        private string createDate;

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

        public string SubjectID
        {
            get
            {
                return subjectID;
            }

            set
            {
                subjectID = value;
            }
        }

        public string QuizName
        {
            get
            {
                return quizName;
            }

            set
            {
                quizName = value;
            }
        }

        public string QuestionCount
        {
            get
            {
                return questionCount;
            }

            set
            {
                questionCount = value;
            }
        }

        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public string QuestionList
        {
            get
            {
                return questionList;
            }

            set
            {
                questionList = value;
            }
        }

        public string CreateDate
        {
            get
            {
                return createDate;
            }

            set
            {
                createDate = value;
            }
        }

        public void QuizIDataReader(SqlDataReader dr)
        {
            Id = dr["id"] is DBNull ? string.Empty : dr["id"].ToString();
            SubjectID = dr["subjectID"] is DBNull ? string.Empty : dr["subjectID"].ToString();
            QuizName = dr["quizName"] is DBNull ? string.Empty : dr["quizName"].ToString();
            Time = dr["time"] is DBNull ? string.Empty : dr["time"].ToString();
            QuestionCount = dr["questionCount"] is DBNull ? string.Empty : dr["questionCount"].ToString();
            QuestionList = dr["questionList"] is DBNull ? string.Empty : dr["questionList"].ToString();
            CreateDate = dr["createDate"] is DBNull ? string.Empty : dr["createDate"].ToString();
        }
    }
}
