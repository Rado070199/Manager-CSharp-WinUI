using ManagerAPI.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManagerAPI.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomersService _service;

        public CustomersController(ICustomersService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allCustomers = await _service.GetAll();
            return View(allCustomers);
        }
    }
}
