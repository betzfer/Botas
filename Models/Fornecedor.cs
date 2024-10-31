using System.ComponentModel.DataAnnotations;

namespace Botas.Models
{
    public class Fornecedor
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
