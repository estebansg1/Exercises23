using System;
using System.Collections.Generic;
using System.Linq;

List<RestaurantOrder> orders = new List<RestaurantOrder>();
WriteMockData(orders);
DisplayOrders(orders);

static void WriteMockData(List<RestaurantOrder> orders)
{
    Random rand = new Random();
    string[] meals = { "Burger", "Pizza", "Taco", "Salad", "Pasta" };
    string[] drinks = { "Coke", "Pepsi", "Water", "Beer", "Wine" };
    string[] waiterNames = { "John", "Jane", "Mike", "Kate", "Tom" };

    for (int i = 1; i <= 10; i++)
    {
        List<string> orderedMeals = new List<string>();
        List<string> orderedDrinks = new List<string>();

        int numMeals = rand.Next(1, 6);
        for (int j = 0; j < numMeals; j++)
        {
            int mealIndex = rand.Next(meals.Length);
            orderedMeals.Add(meals[mealIndex]);
        }

        int numDrinks = rand.Next(1, 6);
        for (int j = 0; j < numDrinks; j++)
        {
            int drinkIndex = rand.Next(drinks.Length);
            orderedDrinks.Add(drinks[drinkIndex]);
        }

        int waiterIndex = rand.Next(waiterNames.Length);

        RestaurantOrder order = new RestaurantOrder()
        {
            Table = i,
            Meals = orderedMeals,
            Drinks = orderedDrinks,
            WaiterName = waiterNames[waiterIndex]
        };

        orders.Add(order);
    }
}

static void DisplayOrders(List<RestaurantOrder> orders)
{
    var sortedOrders = from o in orders
                        orderby o.Table ascending
                        select o;

    foreach (var order in sortedOrders)
    {
        Console.WriteLine($"Table: {order.Table}, Waiter: {order.WaiterName}");
        Console.WriteLine("Meals:");
        foreach (var meal in order.Meals)
        {
            Console.WriteLine($"- {meal}");
        }
        Console.WriteLine("Drinks:");
        foreach (var drink in order.Drinks)
        {
            Console.WriteLine($"- {drink}");
        }
        Console.WriteLine();
    }
}