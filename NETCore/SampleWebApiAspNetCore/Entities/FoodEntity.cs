namespace SampleWebApiAspNetCore.Entities
{
    public class FoodEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int Price { get; set; }
        public DateTime Created { get; set; }
    }
}
