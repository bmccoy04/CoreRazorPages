using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CoreRazorPages.RazorClassLib.Account.Pages
{
    public class LoginModel : PageModel
    {
        private ILogger<LoginModel> _logger;

        
        [BindProperty]
        public LoginViewModel LoginViewModel {get;set;}


        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;            
        }
        public void OnGet()
        {
            _logger.LogDebug("-------   GET ------------");
            LoginViewModel = new LoginViewModel();
            LoginViewModel.UserName = "Bryan";
            LoginViewModel.Password = "Bryan";
            _logger.LogDebug("-------  " + LoginViewModel.UserName + "  " + LoginViewModel.Password + " ------------");
        }

        public IActionResult OnPost()
        {
            _logger.LogDebug("-------  " + LoginViewModel.UserName + "  " + LoginViewModel.Password + " ------------");


            return Page();
        }
    }

    public class LoginViewModel 
    {
        public string UserName {get;set;}
        public string Password {get;set;}
    }
}