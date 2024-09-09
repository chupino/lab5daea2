namespace BlazingPizza.PizzaData
{
    public class PizzaService
    {
        public Task<Pizza[]> GetPizzasAsync()
        {
            var pizzas = new[]
            {
                new Pizza { PizzaId = 1, Name = "Margherita", Description = "Tomato, mozzarella, basil", Price = 9.99m, Vegetarian = true, Vegan = false },
                new Pizza { PizzaId = 2, Name = "Pepperoni", Description = "Tomato, mozzarella, pepperoni", Price = 12.99m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 3, Name = "Veggie", Description = "Tomato, mozzarella, peppers, onions, mushrooms", Price = 11.99m, Vegetarian = true, Vegan = true },
                new Pizza { PizzaId = 4, Name = "BBQ Chicken", Description = "BBQ sauce, mozzarella, chicken", Price = 13.99m, Vegetarian = false, Vegan = false },
                new Pizza { PizzaId = 5, Name = "Four Cheese", Description = "Mozzarella, cheddar, parmesan, gorgonzola", Price = 14.99m, Vegetarian = true, Vegan = false }
            };

            return Task.FromResult(pizzas);
        }
    }
}
