using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DNTest.Entity
{
    public class Question
    {
        private string id;
        private string topicID;
        private string subjectID;
        private string levelID;
        private string typeID;
        private string content;
        private string createDate;

        public Question(string id, string topicId, String subjectId, String levelId, string content, string createDate, string typeId)
        {
            this.id = id;
            this.topicID = topicId;
            this.subjectID = subjectId;
            this.levelID = levelId;
            this.levelID = levelId;
            this.typeID = typeId;
            this.content = content;
            this.createDate = createDate;
        }
        public Question(string topicId, String subjectId)
        {
            this.topicID = topicId;
            this.subjectID = subjectId;
        }
        public Question()
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

        public string TopicID
        {
            get
            {
                return topicID;
            }

            set
            {
                topicID = value;
            }
        }
        public string TypeID
        {
            get
            {
                return typeID;
            }

            set
            {
                typeID = value;
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

        public string LevelID
        {
            get
            {
                return levelID;
            }

            set
            {
                levelID = value;
            }
        }

        public string Content
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
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


        public void QuestionIDataReader(SqlDataReader dr)
        {
            Id = dr["id"] is DBNull ? string.Empty : dr["id"].ToString();
            SubjectID = dr["subjectID"] is DBNull ? string.Empty : dr["subjectID"].ToString();
            TopicID = dr["topicID"] is DBNull ? string.Empty : dr["topicID"].ToString();
            LevelID = dr["levelID"] is DBNull ? string.Empty : dr["levelID"].ToString();
            Content = dr["content"] is DBNull ? string.Empty : dr["content"].ToString();
            CreateDate = dr["createDate"] is DBNull ? "" : dr["createDate"].ToString();
           TypeID = dr["typeID"] is DBNull ? string.Empty : dr["typeID"].ToString();
        }
    }
}
