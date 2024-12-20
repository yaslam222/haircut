using entitylayers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayers
{
    public class context:DbContext
    {
        public context (DbContextOptions<context> options) : base(options) { }
        
        
        
        public DbSet<BeautyCategory> BeautyCategories { get; set; }
        public DbSet<BeautyItem> BeautyItems { get; set; }
        public DbSet<BeautyCardInfo> BeautyCardInfos { get; set; }
        public DbSet<BeautyServiesItem> BeautyServiesItems { get; set; }
        public DbSet<BeautysServices> BeautysServices { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<HaircutMenuCategory> HaircutMenuCategories { get; set; }
        public DbSet<HaircutMenuItem> HaircutMenuItems { get; set; }
        public DbSet<HaircutServicesCategory> HaircutServicesCategories { get; set; }
        public DbSet<HaircutService> HaircutServices { get; set; }
        public DbSet<HaircutSupService> HaircutSupServices { get; set; }
        public DbSet<HairCutTeammember> HairCutTeammembers { get; set; }
    }
}
