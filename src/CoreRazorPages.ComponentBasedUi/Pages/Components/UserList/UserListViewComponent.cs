using CoreRazorPages.ComponentBasedUi.Data.Repository;
using CoreRazorPages.ComponentBasedUi.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRazorPages.ComponentBasedUi.Pages.Components.UserList
{
    public class UserListViewComponent : ViewComponent
    {
        private IUserRepository _userRepo;
        private ILogger<UserListViewComponent> _logger;

        public UserListViewComponent(IUserRepository userRepo, ILogger<UserListViewComponent> logger)
        {
            _userRepo = userRepo;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync(string editRoute, string deleteRoute, string searchString)
        {

            _logger.LogInformation("User view component load");
            _logger.LogInformation(editRoute);
            
            var users = new List<User>();

            if(!string.IsNullOrWhiteSpace(searchString))
                users = _userRepo.Get().Where(x => x.FirstName.Contains(searchString) || x.LastName.Contains(searchString)).ToList();
            else
                users = _userRepo.Get().ToList();

            var viewModel = new UserListViewModel(){
                EditRoute = editRoute,
                DeleteRoute = deleteRoute,
                SearchString = searchString,
                Users = users
            };

            return View(viewModel);
        }
    }

    public class UserListViewModel
    {
        public string EditRoute {get;set;}
        public string DeleteRoute {get;set;}
        public string SearchString {get;set;}
        public List<User> Users {get;set;}
    }
}