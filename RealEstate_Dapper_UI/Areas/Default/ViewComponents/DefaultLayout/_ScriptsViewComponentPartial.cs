using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Areas.Default.ViewComponents.DefaultLayout
{
    public class _ScriptsViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
