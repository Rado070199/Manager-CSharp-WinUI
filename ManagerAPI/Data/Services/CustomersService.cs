using ManagerAPI.Models;

namespace ManagerAPI.Data.Services
{
    public class CustomersService : ICustomersService
    {
        public CustomersService(AppDbContext context) 
        {
        }

        public void Add(Customer actor)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer Update(int id, Customer newActor)
        {
            throw new NotImplementedException();
        }
    }
}
