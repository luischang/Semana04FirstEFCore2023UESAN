namespace Semana04FirstEFCore.API.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsActive { get; set; }

    }
}
