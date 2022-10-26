namespace JacuzziShop.Services.Data
{
    using System.Threading.Tasks;

    using JacuzziShop.Web.ViewModels.Contacts;

    public interface IQuestionService
    {
        Task CreateAsync(QuestionAskInputModel input);
    }
}
