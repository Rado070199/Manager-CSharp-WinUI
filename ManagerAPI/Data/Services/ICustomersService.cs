using ManagerAPI.Models;

namespace ManagerAPI.Data.Services
{
    public interface ICustomersService
    {
        Task<IEnumerable<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(int id);
        Task AddAsync(Customer actor);
        Customer Update(int id, Customer newActor);
        void Delete(int id);
    }
}
