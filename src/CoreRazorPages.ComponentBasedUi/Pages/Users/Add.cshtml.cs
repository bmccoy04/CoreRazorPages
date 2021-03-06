using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [TempData]
        public string Message {get;set;}
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

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            var user = new User() {
                FirstName = UserVm.FirstName,
                LastName = UserVm.LastName,
                Email = UserVm.Email,
                IsCool = UserVm.IsCool
            };

            _userRepo.Add(user); 
            Message = "User Added";
            return RedirectToPage("Index");
        }
    }

    public class UserVm
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public bool IsCool { get; set; }
        public string Id { get; set; }
    }
}