using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNTest.DAL;
using DNTest.Entity;

namespace DNTest.BUS
{
    public class TopicBUS
    {
        private TopicDAL obj = new TopicDAL();
        public List<Topic> Topic_GetByTop(string Top, string Where, string Order)
        {
            return obj.Topic_GetByTop(Top, Where, Order);
        }
        public bool Topic_Insert(Topic data)
        {
            return obj.Topic_Insert(data);
        }

        public bool Topic_Update(Topic data)
        {
            return obj.Topic_Update(data);
        }

        public bool Topic_Delete(string ID)
        {
            return obj.Topic_Delete(ID);
        }
    }
}
