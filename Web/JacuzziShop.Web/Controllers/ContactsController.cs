namespace JacuzziShop.Web.Controllers
{
    using System.Threading.Tasks;

    using JacuzziShop.Services.Data;
    using JacuzziShop.Web.ViewModels.Contacts;
    using Microsoft.AspNetCore.Mvc;

    public class ContactsController : Controller
    {
        private readonly IQuestionService questionService;

        public ContactsController(IQuestionService questionService)
        {
            this.questionService = questionService;
        }

        public IActionResult Question()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Question(QuestionAskInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.questionService.CreateAsync(input);

            return this.Redirect("/");
        }
    }
}
