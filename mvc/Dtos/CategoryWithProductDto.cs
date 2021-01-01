using System.Collections.Generic;

namespace mvc.Dtos
{
    public class CategoryWithProductDto : CategoryDto
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}