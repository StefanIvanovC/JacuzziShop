namespace JacuzziShop.Web.Controllers
{
    using JacuzziShop.Web.ViewModels.Contacts;
    using Microsoft.AspNetCore.Mvc;

    public class ContactsController : Controller
    {
        public IActionResult Question()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Question(QuestionAskInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            return this.Redirect("/");
        }
    }
}
