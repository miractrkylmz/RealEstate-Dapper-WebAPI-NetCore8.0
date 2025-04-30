using Microsoft.AspNetCore.Mvc;

namespace RealEstate_Dapper_UI.Areas.Default.ViewComponents.HomePage
{
    public class _BrandsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
