using System.Linq;

namespace DBEmpire.Backend
{
    public static class UserService
    {
        public static Business.Classes.User.User GetUser(string name)
        {
            DBDataContext contex = new DBDataContext();
            var obj = contex.GetUserByName(name).FirstOrDefault();

            if (obj == null)
            {
                return null;
            }

            Business.Classes.User.User user = new Business.Classes.User.User();
            user.UserID = obj.UserID;
            user.UserName = obj.UserName;

            return user;
        }
    }
}
