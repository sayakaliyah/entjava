
namespace SampleWebApiAspNetCore.Dtos
{
    public class FoodUpdateDto
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int Price { get; set; }
        public DateTime Created { get; set; }
    }
}
