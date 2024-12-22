using datalayers.Abstract;
using entitylayers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayers.Concrate
{
    public class HaircutMenuItemDal:GenericRepository<HaircutMenuItem>,IHaircutMenuItemDal
    {
        public HaircutMenuItemDal(context _context) : base(_context)
        {
        }
        public async Task<IEnumerable<HaircutMenuItem>> GetAllWithCategoryAsync()
        {
            return await _context.HaircutMenuItems
                                 .Where(h => h.HaircutMenuCategory != null) // Exclude items without a category
                                 .Include(h => h.HaircutMenuCategory)
                                 .ToListAsync();
        }
    }
}
