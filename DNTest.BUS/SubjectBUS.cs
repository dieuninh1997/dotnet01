using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNTest.DAL;
using DNTest.Entity;

namespace DNTest.BUS
{
    public class SubjectBUS
    {
        private SubjectDAL obj = new SubjectDAL();
        public List<Subject> Subject_GetByTop(string Top, string Where, string Order)
        {
            return obj.Subject_GetByTop(Top, Where, Order);
        }
        public bool Subject_Insert(Subject data)
        {
            return obj.Subject_Insert(data);
        }

        public bool Subject_Update(Subject data)
        {
            return obj.Subject_Update(data);
        }

        public bool Subject_Delete(string ID)
        {
            return obj.Subject_Delete(ID);
        }
    }
}

