namespace JacuzziShop.Services.Data
{
    using System.Collections.Generic;

    using JacuzziShop.Web.ViewModels.FAQ;

    public interface IFAQService
    {
        IEnumerable<QuestionsAllViewModel> GetAll();
    }
}
