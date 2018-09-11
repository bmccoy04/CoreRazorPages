using CoreRazorPages.ComponentBasedUi.Data.Repository;
using CoreRazorPages.ComponentBasedUi.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreRazorPages.ComponentBasedUi.Pages.Components.GridCrudButtons
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
            _logger.LogDebug("----- Crud Buttons Called ------");
            return View(new CrudButtonViewModel()
            {
                EditRoute = editRoute,
                EntityId = entityId,
                DeleteRoute = deleteRoute
            });
        }
    }

    public class CrudButtonViewModel
    {
        public string EditRoute { get; set; }
        public string EntityId { get; set; }
        public string DeleteRoute { get; set; }
    }

}