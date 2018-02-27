using DNTest.DAL;
using DNTest.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNTest.BUS
{
  public  class TeacherBUS
    {
        TeacherDAL obj = new TeacherDAL();
        public void Update_Password(Teacher data)
        {
            obj.Update_Password(data);
        }
        }
}
