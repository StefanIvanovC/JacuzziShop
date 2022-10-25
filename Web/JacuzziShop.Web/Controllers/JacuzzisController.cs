namespace JacuzziShop.Web.Controllers
{
    using JacuzziShop.Web.ViewModels.Jacuzzis;
    using Microsoft.AspNetCore.Mvc;

    public class JacuzzisController : Controller
    {
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Create(CreateJacuzziInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            return this.Redirect("/");
        }
    }
}
