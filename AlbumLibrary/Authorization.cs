using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumLibrary
{
    public class Authorization
    {
        private List<User> loggedUsers;
        public bool IsLoggedIn { get; private set; }

        public Authorization()
        {
            loggedUsers = new List<User>();
            IsLoggedIn = false;
        }

        public bool SignIn(string userToSignInName, string userToSignInPassword) // voyti v akk
        {
            foreach (var user in loggedUsers)
            {
                if (user.Name == userToSignInName && user.Password == userToSignInPassword)
                {
                    IsLoggedIn = true;
                    return IsLoggedIn;
                }
            }

            return false;
        }


        public bool SignUp(string userToSignUpName, string userToSignUpPassword) //rega
        {
            foreach (var user in loggedUsers)
            {
                if (user.Name == userToSignUpName)
                    return false;
            }

            loggedUsers.Add(new User(userToSignUpName, userToSignUpPassword));
            IsLoggedIn = true;
            return IsLoggedIn;

        }

    }
}
