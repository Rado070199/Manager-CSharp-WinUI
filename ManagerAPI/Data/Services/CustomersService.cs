using ManagerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ManagerAPI.Data.Services
{
    public class CustomersService : ICustomersService
    {
        private readonly AppDbContext _context;
        public CustomersService(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Customer actor)
        {
           await _context.Customers.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            var result = await _context.Customers.ToListAsync();
            return result;
        }

        public async Task<Customer> GetByIdAsync(int id)
        {
            var result = await _context.Customers.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public Customer Update(int id, Customer newActor)
        {
            throw new NotImplementedException();
        }
    }
}
