using CoreRazorPages.ComponentBasedUi.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRazorPages.ComponentBasedUi.Pages.Components.UserForm
{
    public class UserFormViewComponent : ViewComponent
    {
        private IUserRepository _userRepo;
        private ILogger<UserFormViewComponent> _logger;

        public UserFormViewComponent(IUserRepository userRepo, ILogger<UserFormViewComponent> logger)
        {
            _userRepo = userRepo;
            _logger = logger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            _logger.LogInformation("User view component load");
            var items = await Task.FromResult(_userRepo.Get());
            return View("test");
        }
    }
}