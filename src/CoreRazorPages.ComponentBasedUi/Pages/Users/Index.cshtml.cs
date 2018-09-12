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
    public class IndexModel : PageModel
    {
        public string SearchString { get; set; }

        private ILogger _logger;
        private IUserRepository _userRepo;

        public IndexModel(ILogger<AddModel> logger, IUserRepository userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
        }

        public void OnGet(string searchString)
        {
            SearchString = searchString;
        }

        public IActionResult OnPostDelete(string id)
        {
            
            _logger.LogDebug("---------- DELETE " + id + " -------------------");

            _userRepo.Delete(id);

            return RedirectToPage();
        }
    }
}