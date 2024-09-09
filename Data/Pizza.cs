namespace BlazingPizza.Data;
{
    public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            // Devuelve 5 pizzas de ejemplo
            var pizzas = new Pizza[]
            {
                new Pizza
                {
                    PizzaId = 1,
                    Name = "Margherita",
                    Description = "Classic pizza with fresh tomatoes, mozzarella, and basil.",
                    Price = 8.99m,
                    Vegetarian = true,
                    Vegan = false
                },
                new Pizza
                {
                    PizzaId = 2,
                    Name = "Pepperoni",
                    Description = "Delicious pepperoni with mozzarella and tomato sauce.",
                    Price = 10.99m,
                    Vegetarian = false,
                    Vegan = false
                },
                new Pizza
                {
                    PizzaId = 3,
                    Name = "BBQ Chicken",
                    Description = "Grilled chicken, BBQ sauce, onions, and mozzarella.",
                    Price = 12.49m,
                    Vegetarian = false,
                    Vegan = false
                },
                new Pizza
                {
                    PizzaId = 4,
                    Name = "Veggie Delight",
                    Description = "Loaded with mushrooms, onions, peppers, and black olives.",
                    Price = 9.99m,
                    Vegetarian = true,
                    Vegan = true
                },
                new Pizza
                {
                    PizzaId = 5,
                    Name = "Four Cheese",
                    Description = "A blend of mozzarella, cheddar, gouda, and parmesan.",
                    Price = 11.49m,
                    Vegetarian = true,
                    Vegan = false
                }
            };

            return Task.FromResult(pizzas);
        }
    }
}
