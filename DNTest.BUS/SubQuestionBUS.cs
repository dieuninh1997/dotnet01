using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNTest.DAL;
using DNTest.Entity;

namespace DNTest.BUS
{
    public class SubQuestionBUS
    {
        private SubQuestionDAL obj = new SubQuestionDAL();

        public List<SubQuestion> SubQuestion_GetByTop(string Top, string Where, string Order)
        {
            return obj.SubQuestion_GetByTop(Top, Where, Order);
        }

        public int SubQuestion_Insert(SubQuestion data)
        {
            return obj.SubQuestion_Insert(data);
        }
        public bool SubQuestion_Update(SubQuestion data)
        {
            return obj.SubQuestion_Update(data);
        }
        public bool SubQuestion_Delete(String id)
        {
            return obj.SubQuestion_Delete(id);
        }
    }
}
