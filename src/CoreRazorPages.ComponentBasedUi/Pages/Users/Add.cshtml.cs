using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreRazorPages.ComponentBasedUi.Pages.Users
{
    public class AddModel : PageModel
    {
        public UserVm UserVm { get; set; }

        private ILogger _logger;
        private IUserRepository _userRepo;

        public AddModel(ILogger<AddModel> logger, IUserRepository userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
        }

        public void OnGet()
        {
            UserVm = new UserVm();
        }

        public void OnPost()
        {
            var user = new User() {
                FirstName = User.FirstName,
                LastName = User.LastName,
                Email = User.Email,
                IsCool = User.IsCool
            };

            _userRepo.Add(user); 
        }
    }

    public class UserVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsCool { get; set; }
    }
}