using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarvirsBooks.Models
{
    class CoverType
    {
        public class Category
        {
            [Key]

            public int Id { get; set; }

            [Display(Name = "Category Name")]
            [Required]
            [MaxLength(50)]

            public string Name { get; set; }
        }
    }
}
