using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class UserService
    {
        public object GetUser()
        {
            DBDataContext contex = new DBDataContext();
            var obj = contex.GetUserByName("Admin").FirstOrDefault();
            return obj;
        }
    }
}
