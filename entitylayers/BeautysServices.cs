using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entitylayers
{ 
    public class BeautysServices 
    { 
    public int Id { get; set; }

    [Required, StringLength(200)]
    public string? Heading { get; set; }

    [StringLength(500)]
    public string? Subheading { get; set; }

    [StringLength(1000)]
    public string? Description { get; set; }

    public bool IsDeleted { get; set; } = false;

    // Foreign key to BeautyServicesItem
    public int BeautyServicesItemId { get; set; }

    // Navigation property
    public virtual BeautyServiesItem BeautyServicesItem { get; set; } = null!;
}
}
