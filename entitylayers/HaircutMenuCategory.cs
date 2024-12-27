﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayers
{
    public class HaircutMenuCategory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        public bool IsDeleted { get; set; } = false;
        public ICollection<HaircutMenuItem>? HaircutMenuItems { get; set; } = new List<HaircutMenuItem>();
    }
}
