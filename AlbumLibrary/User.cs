using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlbumLibrary
{
    public class User
    {
        static public List<User> Users = new List<User>();

        public readonly Guid Id;
        public string Name { get; set; }

        private string _password;
        public List<User> friendList { get; private set; }
        public List<Album> albumList { get; private set; }

        public string Password
        {
            get { return _password; }
        }


        public User() : this("","") { }

        public User(string name, string password)
        {
            this.Name = name;
            this._password = password;
            this.Id = Guid.NewGuid();
            friendList = new List<User>();
            albumList = new List<Album>();
            Users.Add(this);
        }

        public void CreateAlbum(string _newAlbumTitle)
        {
            var newAlbum = new Album(_newAlbumTitle);
            albumList.Add(newAlbum);
        }

        public void DeleteAlbum(Guid idToDelete)
        {
            var indexToDelete = albumList.FindIndex(x => x.Id == idToDelete);
            if (indexToDelete >= 0) albumList.RemoveAt(indexToDelete);
        }

        public void AddFriend(User _FriendToAdd)
        {
            friendList.Add(_FriendToAdd);
        }

        public void DeleteFriend(Guid idToDelete)
        {
            var indexToDelete = friendList.FindIndex(x => x.Id == idToDelete);
            if (indexToDelete >= 0) friendList.RemoveAt(indexToDelete);
        }

        public override string ToString()
        {
            return Name;
        }

        static List<User> GetUsersNoFriends()
        {
            var res = new List<User>();
            foreach (var user in Users)
            {
                if(user.friendList.Count == 0)
                    res.Add(user);
            }

            return res;
        }

        static List<User> GetUsersNoPhotos()
        {
            var res = new List<User>();
            foreach (var user in Users)
            {
                if (user.albumList.Count == 0)
                    res.Add(user);
            }

            return res;
        }

    }
}
