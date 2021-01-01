using System.ComponentModel.DataAnnotations;

namespace api.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}