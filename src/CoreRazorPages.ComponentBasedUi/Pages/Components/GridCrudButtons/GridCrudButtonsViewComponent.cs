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
    public class GridCrudButtonsViewComponent : ViewComponent
    {
        private ILogger<GridCrudButtonsViewComponent> _logger;

        public GridCrudButtonsViewComponent(ILogger<GridCrudButtonsViewComponent> logger)
        {
            _logger = logger;
        }

        public IViewComponentResult Invoke(string editRoute, string deleteRoute, string entityId)
        {
            return View(new CrudButtonViewComponent()
            {
                EditRoute = editRoute,
                DeleteRoute = deleteRoute,
                EntityId = entityId
            });
        }
    }

    public class CrudButtonViewComponent
    {
        public string EditRoute { get; set; }
        public string EntityId { get; set; }
        public string DeleteRoute { get; set; }
    }

}