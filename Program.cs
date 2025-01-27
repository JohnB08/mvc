using mvc.Controllers;
using mvc.Models;
using mvc.View;
using mvc.App;

namespace mvc;

class Program
{
    static void Main(string[] args)
    {
        var meny = new MenyItems();
        var customers = new Customers();

        var menyDisplayer = new RenderMeny();
        var customerDisplayer = new RenderCustomers();

        var menyController = new MenyController(meny, menyDisplayer);
        var customerController = new CustomerController(customers, customerDisplayer);

        var app = new LaPizzeriaApp(menyController, customerController);
        
        app.Run();
    }
}
