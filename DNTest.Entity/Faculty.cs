using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DNTest.Entity
{
    public class Faculty
    {
        private string id;
        private string facultyName;
        public Faculty()
        {

        }
        public Faculty(string id, string facultyName)
        {
            this.id = id;
            this.facultyName = facultyName;
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

        public string FacultyName
        {
            get
            {
                return facultyName;
            }

            set
            {
                facultyName = value;
            }
        }

        public void FacultyIDataReader(SqlDataReader dr)
        {
            Id = dr["id"] is DBNull ? string.Empty : dr["id"].ToString();
            FacultyName = dr["facultyName"] is DBNull ? string.Empty : dr["facultyName"].ToString();
        }
    }
}
