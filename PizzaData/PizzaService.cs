namespace BlazingPizza.PizzaData
{
    public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            var pizzas = new[]
            {
                new Pizza { Name = "Margherita", Description = "Tomato, mozzarella, basil", Price = 9.99m, Vegetarian = true, Vegan = false },
                new Pizza { Name = "Pepperoni", Description = "Tomato, mozzarella, pepperoni", Price = 12.99m, Vegetarian = false, Vegan = false },
                new Pizza { Name = "Veggie", Description = "Tomato, mozzarella, peppers, onions, mushrooms", Price = 11.99m, Vegetarian = true, Vegan = true },
                new Pizza { Name = "BBQ Chicken", Description = "BBQ sauce, mozzarella, chicken", Price = 13.99m, Vegetarian = false, Vegan = false },
                new Pizza { Name = "Four Cheese", Description = "Mozzarella, cheddar, parmesan, gorgonzola", Price = 14.99m, Vegetarian = true, Vegan = false }
            };

            return Task.FromResult(pizzas);
        }
    }
}
