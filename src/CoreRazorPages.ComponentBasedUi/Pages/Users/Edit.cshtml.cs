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
    public class EditModel : PageModel
    {
        [BindProperty]
        public UserVm UserVm { get; set; }
        private ILogger _logger;
        private IUserRepository _userRepo;

        public EditModel(ILogger<AddModel> logger, IUserRepository userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
        }

        public void OnGet(string id)
        {
            var user = _userRepo.Get(id);
            UserVm = new UserVm() {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                IsCool = user.IsCool
            };
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation("User's Id: -------- " + UserVm.Id);
            var user = new User() {
                Id = UserVm.Id,
                FirstName = UserVm.FirstName,
                LastName = UserVm.LastName,
                Email = UserVm.Email,
                IsCool = UserVm.IsCool
            };

            _userRepo.Update(user); 
            
            return RedirectToPage("Index");
        }
    }

}