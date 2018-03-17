using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNTest.DAL;
using DNTest.Entity;

namespace DNTest.BUS
{
    public class QuizBUS
    {
        private QuizDAL obj = new QuizDAL();
        public List<Entity.Quiz> Quiz_GetByTop(string Top, string Where, string Order)
        {
            return obj.Quiz_GetByTop(Top, Where, Order);
        }
        public int Quiz_Insert(Entity.Quiz data)
        {
            return obj.Quiz_Insert(data);
        }

        public bool Quiz_Update(Entity.Quiz data)
        {
            return obj.Quiz_Update(data);
        }

        public bool Quiz_Delete(string ID)
        {
            return obj.Quiz_Delete(ID);
        }
    }
}
