using ManagerAPI.Models;

namespace ManagerAPI.Data.Services
{
    public interface ICustomersService
    {
        Task<IEnumerable<Customer>> GetAll();
        Customer GetById(int id);
        void Add(Customer actor);
        Customer Update(int id, Customer newActor);
        void Delete(int id);
    }
}
