using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Areas.Default.ViewComponents.DefaultLayout
{
    public class _NavbarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
