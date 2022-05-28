using Login_Form2.Models;
using System.Collections.Generic;
using System.Linq;

namespace Login_Form2.Services
{
    public class SecurityService
    {
        List<UserModel> KnownUsers = new List<UserModel>();

        public SecurityService()
        {
            KnownUsers.Add(new UserModel { Id = 0, Username = "Chantal", Password = "12" });
            KnownUsers.Add(new UserModel { Id = 1, Username = "Yohan", Password = "123" });
            KnownUsers.Add(new UserModel { Id = 2, Username = "Pethuel", Password = "1234" });
            KnownUsers.Add(new UserModel { Id = 3, Username = "Dave", Password = "12345" });
        }

        public bool IsValid(UserModel user)
        {
            return KnownUsers.Any(x => x.Username == user.Username && x.Password == user.Password);

        }
    }

   }
