using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Xml;

namespace AlbumLibrary
{
    [DataContract]
    public class Authorization
    {
        
        private List<User> loggedUsers;

        private static Serializer<User> loggedUserSerializer = new Serializer<User>();

        public List<User> LoggedUsers
        { 
            get { return loggedUsers; }
            set { loggedUsers = value; }
        }

        public bool IsLoggedIn { get; private set; }

        private static Authorization _instance;

        //при закрытии логгед юзерс обнуляется
        //[]
        public static void LoadLoggedUsers(SerializationType sType = SerializationType.XML)
        {
            switch (sType)
            {
                case SerializationType.XML:
                    ((IXMLSerializer)loggedUserSerializer).Deserialize(out Authorization.getInstance().loggedUsers, "LoggedUsers.xml");
                    break;
                case SerializationType.JSON:
                    ((IJSONSerializer)loggedUserSerializer).Deserialize(out Authorization.getInstance().loggedUsers, "LoggedUsers.json");
                    break;

            }

        }

        public static void SaveLoggedUsers(SerializationType sType = SerializationType.XML)
        {
            switch (sType)
            {
                case SerializationType.XML:
                    ((IXMLSerializer)loggedUserSerializer).Serialize(Authorization.getInstance().loggedUsers, "LoggedUsers.xml");
                    break;
                case SerializationType.JSON:
                    ((IJSONSerializer)loggedUserSerializer).Serialize(Authorization.getInstance().loggedUsers, "LoggedUsers.json");
                    break;
            }
        }


        public Authorization()
        {
            loggedUsers = new List<User>();
            IsLoggedIn = false;
        }

        ~Authorization()
        {
            SaveLoggedUsers();
        }


        public static Authorization getInstance()
        {
            if(_instance == null)
                _instance = new Authorization();
            return _instance;
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
