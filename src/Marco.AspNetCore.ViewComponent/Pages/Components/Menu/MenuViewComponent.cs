using Marco.AspNetCore.ViewComponent.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Pages.Components.RatingControl
{
    [ViewComponent(Name = "Menu")]
    public class MenuViewComponent : ViewComponent
    {
        public MenuViewComponent() { }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // For cache menu using package
            // https://github.com/marcoaurelioit/marco-caching

            var menuItens = await GetFakeMenuItensFromRepository();

            return View(menuItens);
        }

        private async Task<IEnumerable<MenuViewModel>> GetFakeMenuItensFromRepository()
        {
            // Fake menu itens
            return await Task.FromResult(new MenuViewModel[]
               {
                new MenuViewModel{Order = 1, Title = "Home", Description = "Home page for application", Path = "/Index"},
                new MenuViewModel{Order = 2, Title = "About", Description = "About for application", Path = "/About"},
                new MenuViewModel{Order = 3, Title = "Contact", Description = "Contact info for application", Path = "/Contact"}
               });
        }
    }
}