using System.ComponentModel.DataAnnotations;

namespace ManagerAPI.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
        public List<Order> Orders { get; set; }
    }
}
