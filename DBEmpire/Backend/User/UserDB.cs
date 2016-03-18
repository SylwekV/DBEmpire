using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using LinqToDB.Mapping;

namespace DBEmpire.Backend.User
{
    [Table(Name = "Users")]
    public class UserDB
    {
        [PrimaryKey, Identity]
        public int UserID { get; set; }

        [Column(Name = "UserName"), NotNull]
        public string UserName { get; set; }

        [Column(Name = "UserIsValid"), NotNull]
        public bool UserIsValid { get; set; }
    }
}