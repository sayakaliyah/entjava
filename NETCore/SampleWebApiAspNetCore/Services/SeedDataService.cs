using SampleWebApiAspNetCore.Entities;
using SampleWebApiAspNetCore.Repositories;

namespace SampleWebApiAspNetCore.Services
{
    public class SeedDataService : ISeedDataService
    {
        public void Initialize(FoodDbContext context)
        {
            context.FoodItems.Add(new FoodEntity() { Price = 100, Type = "Dessert", Name = "Cookies", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Price = 200, Type = "Snacks", Name = "Fries", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Price = 300, Type = "Main", Name = "Carbonara", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Price = 400, Type = "Main", Name = "Steak", Created = DateTime.Now });

            context.SaveChanges();
        }
    }
} 
