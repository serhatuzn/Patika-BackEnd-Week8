using BasicMVCProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVCProject.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            // Basit bir model örneği oluşturuyoruz
            var customer = new Customer
            {
                Id = 25062023,
                FirstName = "Serhat",
                LastName = "Uzun",
                Email = "seerhatuzun@gmail.com"
            };

            var orders = new List<Order>()
            {
                new Order{OrderId = 1, ProductName = "Playstation 5", Price = 20000, Quantity = 22},
                new Order{OrderId = 2, ProductName = "Iphone 16", Price = 60000, Quantity = 40},
                new Order{OrderId = 3, ProductName = "Dyson", Price = 25500, Quantity = 33},
                new Order{OrderId = 4, ProductName = "TV", Price = 17000, Quantity = 50},
                new Order{OrderId = 5, ProductName = "Table", Price = 1750, Quantity = 145},
                new Order{OrderId = 6, ProductName = "Mouse", Price = 10000, Quantity = 78},
            };

            // ViewModel oluşturup view'a gönderiyoruz
            var viewModel = new CustomerOrderViewModel()
            {
                Customer = customer,
                Orders = orders
            };

            return View(viewModel);
        }
    }
}