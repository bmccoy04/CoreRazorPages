using System;
using System.Collections.Generic;
using CoreRazorPages.ComponentBasedUi.Shared.Entities;
using CoreRazorPages.ComponentBasedUi.Data.Context;

namespace CoreRazorPages.ComponentBasedUi.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public User Add(User user)
        {
            return UserData.Add(user);
        }

        public bool Delete(string userId)
        {
            return UserData.Delete(userId);
        }

        public IEnumerable<User> Get()
        {
           return UserData.Get();
        }

        public User Get(string id)
        {
            return UserData.Get(id);
        }

        public User Update(User user)
        {
            return UserData.Update(user);
        }
    }
}