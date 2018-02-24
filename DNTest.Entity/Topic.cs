using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DNTest.Entity
{
    public class Topic
    {
        private String id;
        private String topicName;
        private String subjectID;

        public Topic(string id, string name, String subjectID)
        {
            this.Id = id;
            this.topicName = name;
            this.subjectID = subjectID;
        }
        public Topic(string name, String subjectID)
        {
            this.topicName = name;
            this.subjectID = subjectID;
        }
        public Topic()
        {

        }
        public String SubjectID
        {
            get { return subjectID; }
            set { subjectID = value; }
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

        public string TopicName
        {
            get
            {
                return topicName;
            }

            set
            {
                topicName = value;
            }
        }

        public void TopicIDataReader(SqlDataReader dr)
        {
            Id = dr["id"] is DBNull ? string.Empty : dr["id"].ToString();
            TopicName = dr["topicName"] is DBNull ? string.Empty : dr["topicName"].ToString();
            SubjectID = dr["subjectID"] is DBNull ? string.Empty : dr["subjectID"].ToString();
        }
    }
}
