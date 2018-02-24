using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNTest.DAL;
using DNTest.Entity;

namespace DNTest.BUS
{
    public class FacultyBUS
    {
        private FacultyDAL obj = new FacultyDAL();
        public List<Faculty> Faculty_GetByTop(string Top, string Where, string Order)
        {
            return obj.Faculty_GetByTop(Top, Where, Order);
        }
        public bool Faculty_Insert(Faculty data)
        {
            return obj.Faculty_Insert(data);
        }

        public bool Faculty_Update(Faculty data)
        {
            return obj.Faculty_Update(data);
        }

        public bool Faculty_Delete(string ID)
        {
            return obj.Faculty_Delete(ID);
        }
    }
}

