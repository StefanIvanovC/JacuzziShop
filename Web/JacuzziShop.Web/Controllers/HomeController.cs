namespace JacuzziShop.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using JacuzziShop.Data;
    using JacuzziShop.Web.ViewModels;
    using JacuzziShop.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            // Direct use of Database Variant by injecting ApplicationDbContex in the constructor
            var viewModel = new IndexViewModel
            {
                ExtrasCount = this.db.Extras.Count(),
                JacuzzisCount = this.db.Jacuzzis.Count(),
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
