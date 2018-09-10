using System;
using System.Collections.Generic;
using System.Linq;
using CoreRazorPages.ComponentBasedUi.Shared.Entities;

namespace CoreRazorPages.ComponentBasedUi.Data.Context
{
    public static class UserData
    {
        private static List<User> Users;

        public static User Add(User user)
        {
            user.Id = Guid.NewGuid().ToString();

            if(Users == null)
                Users = new List<User>();

            Users.Add(user);

            return user;
        }

        public static User Update(User user)
        {
            var u = Users.FirstOrDefault(x => x.Id == user.Id);
            if(u == null)
                throw new Exception("User doesn't exist");
            
            u.FirstName = user.FirstName;
            u.LastName = user.LastName;
            u.Email = user.Email;
            u.IsCool = user.IsCool;

            return u;
        }

        public static IEnumerable<User> Get()
        {
            if(Users == null)
                Users = new List<User>();
            return Users;
        }


        public static User Get(string id)
        {
            if(Users == null)
                Users = new List<User>();
            return Users.FirstOrDefault(x => x.Id == id);
        }

        public static bool Delete(string userId)
        {
            if(Users == null)
                Users = new List<User>();
            var user = Users.FirstOrDefault(x => x.Id == userId);
            Users.Remove(user);
            
            return true;
        }
    }
}