namespace JacuzziShop.Web.Controllers
{
    using JacuzziShop.Data;
    using JacuzziShop.Services.Data;
    using JacuzziShop.Web.ViewModels.FAQ;
    using Microsoft.AspNetCore.Mvc;

    public class FAQController : Controller
    {
        private readonly IFAQService questionservice;

        public FAQController(IFAQService questionservice)
        {
            this.questionservice = questionservice;
        }

        public IActionResult All()
        {
            var viewModel = new FAQListViewModel
            {
                Questions = this.questionservice.GetAll(),
            };

            return this.View(viewModel);
        }
    }
}
