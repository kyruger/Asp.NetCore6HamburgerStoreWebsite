﻿using Microsoft.AspNetCore.Mvc;

namespace Hamburger_Application.Areas.User.ViewComponents.Account
{
    public class _AccountLayoutFooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
