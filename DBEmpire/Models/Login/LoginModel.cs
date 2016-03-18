using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace DBEmpire.Models.Login
{
    public class LoginModel
    {
        [DisplayName("Nazwa użytkownika")]
        public string UserName { get; set; }

        [DisplayName("Hasło")]
        public string Password { get; set; }
    }
}