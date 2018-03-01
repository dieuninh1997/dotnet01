using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNTest.DAL;
using DNTest.Entity;

namespace DNTest.BUS
{
    public class AnswerBUS
    {
        private AnswerDAL obj = new AnswerDAL();
        public List<Answer> Answer_GetByTop(string Top, string Where, string Order)
        {
            return obj.Answer_GetByTop(Top, Where, Order);
        }
        public bool Answer_Insert(Answer data)
        {
            return obj.Answer_Insert(data);
        }

        public bool Answer_Update(Answer data)
        {
            return obj.Answer_Update(data);
        }

        public bool Answer_Delete(string ID)
        {
            return obj.Answer_Delete(ID);
        }
    }
}

