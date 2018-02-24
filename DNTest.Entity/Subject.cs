using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DNTest.Entity
{
    public class Subject
    {
        private String id;
        private String subjectName;
        private String facultyID;

        public Subject(string id, string name, String facultyID)
        {
            this.Id = id;
            this.SubjectName = name;
            this.FacultyID = facultyID;
        }
        public Subject(string name, String facultyID)
        {
            this.SubjectName = name;
            this.FacultyID = facultyID;
        }
        public Subject()
        {

        }
        public String FacultyID
        {
            get { return facultyID; }
            set { facultyID = value; }
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

        public string SubjectName
        {
            get
            {
                return subjectName;
            }

            set
            {
                subjectName = value;
            }
        }

        public void SubjectIDataReader(SqlDataReader dr)
        {
            Id = dr["id"] is DBNull ? string.Empty : dr["id"].ToString();
            SubjectName = dr["subjectName"] is DBNull ? string.Empty : dr["subjectName"].ToString();
            FacultyID = dr["facultyID"] is DBNull ? string.Empty : dr["facultyID"].ToString();    
        }
    }
}
