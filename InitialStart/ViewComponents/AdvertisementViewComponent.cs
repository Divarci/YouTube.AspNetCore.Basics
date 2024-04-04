using Microsoft.AspNetCore.Mvc;

namespace InitialStart.ViewComponents
{
    public class AdvertisementViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<string> list = new() { "michael","amanda" };
            return View(list);
        }
    }
}
