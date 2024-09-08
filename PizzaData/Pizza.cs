namespace BlazingPizza.PizzaData
{
    public class Pizza
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool Vegetarian { get; set; }
        public bool Vegan { get; set; }
        public decimal Price { get; set; }
    }
}
