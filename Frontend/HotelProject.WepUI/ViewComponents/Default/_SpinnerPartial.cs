using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WepUI.ViewComponents.Default
{
    public class _SpinnerPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
