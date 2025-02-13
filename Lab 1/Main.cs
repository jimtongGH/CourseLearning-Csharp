// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Concurrent;
using AutomatedWarehouse;
using Lab_1;

class main
{
    static void Main()
    {
        // Product product = new Product("MacBook Pro");
        
        List<Order> orders = new List<Order>();
        List<WarehouseRobot> robots = new List<WarehouseRobot>
        {
            new PackingRobot("PackingBot"),
            new DispatchRobot("DispatchBot"),
            new DeliveryRobot("DeliveryBot")
        };
        
        
        // Console.WriteLine($"Ordered product: {order.OrderedProduct.Name}");
        // Console.WriteLine($"Order state: {order.State}");
        // Console.WriteLine($"Before processing: {order.State}");
        
        // foreach (var robot in robots)
        // {
        //     robot.ProcessOrder(order);
        //     Console.WriteLine($"After {robot.Name} processing: {order.State}");
        // }

        while (true)
        {
            Console.WriteLine("Welcome to the warehouse management. Choose one of the following:");
            Console.WriteLine("1. Add a new order");
            Console.WriteLine("2. Display status of all orders");
            Console.WriteLine("3. Process the last order by each robot");
            Console.WriteLine("4. Exit the program");
            Console.Write("Enter your choice: ");

            var key = Console.ReadLine();
            switch (key)
            {
                case "1":
                    Console.WriteLine("Enter the product name: ");
                    string productName = Console.ReadLine();
                    Order newOrder = new Order(new Product(productName));
                    orders.Add(newOrder);
                    Console.WriteLine($"Order added: {newOrder.OrderedProduct.Name} - State: {newOrder.State}");
                    break;
                
                case "2":
                    if (orders.Count == 0)
                    {
                        Console.WriteLine("No orders to display.");
                    }
                    else
                    {
                        Console.WriteLine("All orders:");
                        foreach (var order in orders)
                        {
                            Console.WriteLine($"Product: {order.OrderedProduct.Name} - State: {order.State}");
                        }
                    }
                    break;
                
                case "3":
                    if (orders.Count == 0)
                    {
                        Console.WriteLine("No orders to process.");
                    }
                    else
                    {
                        Order lastOrder = orders[orders.Count - 1];
                        Console.WriteLine($"Processing last order: {lastOrder.OrderedProduct.Name} - State: {lastOrder.State}");
                        foreach (WarehouseRobot robot in robots)
                        {
                            robot.ProcessOrder(lastOrder);
                            Console.WriteLine($"After {robot.Name} processing: {lastOrder.State}");
                        }
                    }
                    break;
                
                case "4":
                    Console.WriteLine("Exiting the program...");
                    return;
                
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}