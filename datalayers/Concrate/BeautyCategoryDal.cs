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
    public class BeautyCategoryDal : GenericRepository<BeautyCategory>, IBeautyCategoryDal
    {

        public BeautyCategoryDal(context _context) : base(_context)
        {

        }
        public async Task<BeautyCategory?> GetCategoryWithItemsAsync(int id)
        {
            return await _dbSet
                .Include(c => c.BeautyItems)
                .FirstOrDefaultAsync(c => c.Id == id);
        }






    }
}
