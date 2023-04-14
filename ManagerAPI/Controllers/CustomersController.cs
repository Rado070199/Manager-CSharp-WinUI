using ManagerAPI.Data.Services;
using ManagerAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ManagerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _service;

        public CustomersController(ICustomersService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var allCustomers = await _service.GetAllAsync();
            return Ok(allCustomers);
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return Ok();
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest("Customer cannot be null.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.AddAsync(customer);

            return CreatedAtAction(nameof(Details), new { id = customer.Id }, customer);
        }

        [HttpGet("Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var customerDetails = await _service.GetByIdAsync(id);

            if (customerDetails == null)
            {
                return NotFound();
            }

            return Ok(customerDetails);
        }
    }
}
