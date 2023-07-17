using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.User.ViewComponents.Account
{
    public class _AccountLayoutScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
