using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayers
{
    public class BeautyServiesItem
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string? Title { get; set; }

        [StringLength(200)]
        public string? ImagePath { get; set; }

        public bool IsDeleted { get; set; } = false;

        // Navigation property for related service (one-to-one)
        public virtual BeautysServices? BeautyService { get; set; }
    }
}
