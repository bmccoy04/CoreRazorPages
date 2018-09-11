using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreRazorPages.ComponentBasedUi.Data.Repository;
using CoreRazorPages.ComponentBasedUi.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CoreRazorPages.ComponentBasedUi.Pages.Users
{
    public class AddModel : PageModel
    {
        [BindProperty]
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
            UserVm.FirstName = "test";
        }

        public IActionResult OnPost()
        {
            var user = new User() {
                FirstName = UserVm.FirstName,
                LastName = UserVm.LastName,
                Email = UserVm.Email,
                IsCool = UserVm.IsCool
            };

            _userRepo.Add(user); 
            
            return RedirectToPage("Index");
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