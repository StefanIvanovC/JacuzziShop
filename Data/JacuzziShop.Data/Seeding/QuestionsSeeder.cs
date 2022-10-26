namespace JacuzziShop.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using JacuzziShop.Data.Models;

    public class QuestionsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Questions.Any())
            {
                return;
            }

            await dbContext.Questions.AddAsync(new Question { QuestionTitle = "TestSeeder1", QuestionDescription = "TestSeederDescription1", Email = "Test1@gmail.com", Name = "NicknameTest1" });
            await dbContext.Questions.AddAsync(new Question { QuestionTitle = "TestSeeder2", QuestionDescription = "TestSeederDescription2", Email = "Test2@gmail.com", Name = "NicknameTest2" });
            await dbContext.Questions.AddAsync(new Question { QuestionTitle = "TestSeeder3", QuestionDescription = "TestSeederDescription3", Email = "Test3@gmail.com", Name = "NicknameTest3" });

            await dbContext.SaveChangesAsync();
        }
    }
}
