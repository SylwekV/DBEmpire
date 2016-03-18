using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBEmpire.Backend.User;
using DBEmpire.Business.Classes.Login;
using LinqToDB;
using DBEmpire.Business.Classes.User;

namespace DBEmpire.Backend
{
    public class MySqlProvider : LinqToDB.Data.DataConnection
    {
        public MySqlProvider()  : base("MySQLDB") { }

        public ITable<UserDB> User { get { return GetTable<UserDB>(); } }
    }

    public static class UserProvider
    {
        public static List<Business.Classes.User.User> All()
        {
            using (var db = new MySqlProvider())
            {
                var query = from p in db.User
                            select p;

                return query.ToList().Select(userDB => new Business.Classes.User.User()
                {
                    UserID = userDB.UserID, UserName = userDB.UserName
                }).ToList();
            }
        }

        public static LoginResult LogIn(string userName, string userPassword)
        {
            using (var db = new MySqlProvider())
            {
                var queryResult = (from p in db.User
                                  where p.UserName == userName && 
                                  p.UserIsValid
                                  select p).FirstOrDefault();

                LoginResult result = new LoginResult();

                if (queryResult == null)
                {
                    result.Response = LoginResponse.NotFound;
                }
                else
                {
                    result.Response = LoginResponse.Success;
                    result.User = new Business.Classes.User.User()
                    {
                        UserID = queryResult.UserID,
                        UserName = queryResult.UserName
                    };
                }
                return result;



            }
        }

    }

}