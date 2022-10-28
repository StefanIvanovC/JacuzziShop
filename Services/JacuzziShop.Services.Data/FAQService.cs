namespace JacuzziShop.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using JacuzziShop.Data.Common.Repositories;
    using JacuzziShop.Data.Models;
    using JacuzziShop.Web.ViewModels.FAQ;

    public class FAQService : IFAQService
    {
        private readonly IDeletableEntityRepository<Question> questionsRepository;

        public FAQService(IDeletableEntityRepository<Question> questionsRepository)
        {
            this.questionsRepository = questionsRepository;
        }

        public IEnumerable<QuestionsAllViewModel> GetAll()
        {
           var all = this.questionsRepository.All().OrderBy(x => x.CreatedOn).Select(x => new QuestionsAllViewModel
            {
                QuestionTitle = x.QuestionTitle,
                QuestionDescription = x.QuestionDescription,
            }).ToList();

           return all;
        }
    }
}
