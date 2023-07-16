using Microsoft.AspNetCore.Mvc.Rendering;

namespace Hamburger_Application.Areas.Admin.Models.ViewModels.Menu
{
    public class CreateMenuVM
    {
        public Hamburger_Application.Entities.Concrete.Menu Menu { get; set; }
        public SelectList Fries { get; set; }
        public SelectList Drinks { get; set; }
        public SelectList Hamburgers { get; set; }
        public IFormFile imgCover { get; set; }
    }
}
