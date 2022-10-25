namespace JacuzziShop.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using JacuzziShop.Data.Models;

    public class ExtrasSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Extras.Any())
            {
                return;
            }

            await dbContext.Extras.AddAsync(new Extra { Name = "Ultra bubbles" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Turbo jets" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Waterfall" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Underwater music" });
            await dbContext.Extras.AddAsync(new Extra { Name = "Romantic lightening" });
        }
    }
}
