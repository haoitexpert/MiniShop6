using System.ComponentModel.DataAnnotations;

namespace MiniShop6.Data
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name..")]
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
    }
}
