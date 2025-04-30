using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Areas.Default.ViewComponents.DefaultLayout
{
    public class _HeaderViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
