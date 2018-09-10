using System.Collections.Generic;
using CoreRazorPages.ComponentBasedUi.Shared.Entities;

namespace CoreRazorPages.ComponentBasedUi.Data.Repository
{
    public interface IUserRepository
    {
        User Add(User user);

        User Update(User user);

        IEnumerable<User> Get();


        User Get(string id);

        bool Delete(string userId);
    }
}