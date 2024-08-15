namespace FoodMenuApp.Models;

public class Dish
{
    public int Id { get; set; }
    public string Name { get; set; }
    private string ImageUrl { get; set; }
    private  double Price { get; set; }
    
    public List<DishIngredient>? DishIngredients { get; set; }
}