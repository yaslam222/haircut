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
    public class HaircutMenuCategoryDal:GenericRepository<HaircutMenuCategory>,IHaircutMenuCategoryDal
    {
        public HaircutMenuCategoryDal(context _context) : base(_context)
        {
        }
        public async Task<IEnumerable<HaircutMenuItem>> GetHaircutMenuItemsByCategoryIdAsync(int categoryId)
        {
            return await _context.HaircutMenuItems
                                 .Where(hmi => hmi.HaircutMenuCategoryId == categoryId && !hmi.IsDeleted)
                                 .ToListAsync();
        }
    }
}
