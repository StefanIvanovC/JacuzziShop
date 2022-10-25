namespace JacuzziShop.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using JacuzziShop.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category { Name = "Luxyry" });
            await dbContext.Categories.AddAsync(new Category { Name = "Outdoor" });
            await dbContext.Categories.AddAsync(new Category { Name = "Indor" });
            await dbContext.Categories.AddAsync(new Category { Name = "Premium" });
            await dbContext.Categories.AddAsync(new Category { Name = "UltraCheap" });

            await dbContext.SaveChangesAsync();
        }
    }
}
