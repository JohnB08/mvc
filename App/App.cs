using System;
using mvc.Controllers;

namespace mvc.App;

public class LaPizzeriaApp(MenyController menyController, CustomerController customerController)
{
    private readonly MenyController _menyController = menyController;
    private readonly CustomerController _customerController = customerController;

    private bool isRunning = true;

    public void Run()
    {
        while (isRunning)
        {
            Console.WriteLine("Welcome to La Pizzeria");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("press 1 for registering a new customer");
            Console.WriteLine("press 2 for unregistering a new customer");
            Console.WriteLine("press 3 to see the available meny");
            Console.WriteLine("press 4 to check availability of an item");
            Console.WriteLine("press 5 to exit.");
            var input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    _customerController.AddCustomer();
                    break;
                case "2":
                    _customerController.RemoveCustomer();
                    break;
                case "3":
                    _menyController.GetAllMenyItems();
                    break;
                case "4":
                    _menyController.IsPizzaAvaliable();
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Not supported");
                    break;
            }
        }
    }

}
