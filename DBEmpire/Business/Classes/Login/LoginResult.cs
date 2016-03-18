using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBEmpire.Business.Classes.Login
{
    public class LoginResult
    {
        public LoginResponse Response;
        public User.User User;
    }

    public enum LoginResponse
    {
        Success,
        Ban,
        NotFound
    }
}