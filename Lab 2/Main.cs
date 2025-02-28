// See https://aka.ms/new-console-template for more information
using System;
using Lab_2;

class main
{
    public static void Main()
    {
        try
        {
            var phoneDB = new PhoneDB(new List<string> { "Alice", "Bob", "Charlie" });

            phoneDB.AddEntry("Alice", "12345");
            phoneDB.AddEntry("Alice", "67890");
            phoneDB.AddEntry("Bob", "54321");

            Console.WriteLine("Alice's numbers: " + string.Join(", ", phoneDB.FindPhones("Alice")));
            Console.WriteLine("Bob's numbers: " + string.Join(", ", phoneDB.FindPhones("Bob")));

            phoneDB.RemoveEntry("Alice", "12345");
            Console.WriteLine("Alice's numbers after removal: " + string.Join(", ", phoneDB.FindPhones("Alice")));

            phoneDB.FindPhones("Charlie"); // Charlie 没有号码，应该抛异常
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}