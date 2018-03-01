using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNTest.Entity
{
    public class MultiQuestion
    {
        public string content { get; set; }
        public List<SimpleQuestion> lstQuestion { get; set; }

        public MultiQuestion()
        {
            this.content = "";
            this.lstQuestion = new List<SimpleQuestion>();
        }
    }
}
