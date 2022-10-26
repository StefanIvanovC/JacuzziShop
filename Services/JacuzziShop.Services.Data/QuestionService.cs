namespace JacuzziShop.Services.Data
{
    using System.Threading.Tasks;

    using JacuzziShop.Data.Common.Repositories;
    using JacuzziShop.Data.Models;
    using JacuzziShop.Web.ViewModels.Contacts;

    public class QuestionService : IQuestionService
    {
        private readonly IDeletableEntityRepository<Question> questionsRepository;

        public QuestionService(IDeletableEntityRepository<Question> questionsRepository)
        {
           this.questionsRepository = questionsRepository;
        }

        public async Task CreateAsync(QuestionAskInputModel input)
        {
            var question = new Question
            {
                QuestionTitle = input.About,
                QuestionDescription = input.QuestionDescription,
                Email = input.Email,
                Name = input.Name,
            };

            await this.questionsRepository.AddAsync(question);
            await this.questionsRepository.SaveChangesAsync();
        }
    }
}
