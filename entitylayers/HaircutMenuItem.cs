using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayers
{
    public class HaircutMenuItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        public decimal Price { get; set; }
        public string? Time { get; set; }

        // Foreign Key
        public int HaircutMenuCategoryId { get; set; }

        public bool IsDeleted { get; set; } = false;
        public HaircutMenuCategory? HaircutMenuCategory { get; set; }
    }
}
