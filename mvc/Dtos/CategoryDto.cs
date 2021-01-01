using System.ComponentModel.DataAnnotations;

namespace mvc.Dtos
{
    public class CategoryDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is not empty")]
        public string Name { get; set; }
    }
}