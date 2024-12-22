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
    public class BeautyItemDal:GenericRepository<BeautyItem>,IBeautyItemDal
    {
        public BeautyItemDal(context _context) : base(_context)
        {
        }
        public async Task<IEnumerable<BeautyItem>> GetByCategoryIdAsync(int categoryId)
        {
            return await _dbSet
                .Where(item => item.BeautyCategoryId == categoryId && !item.IsDeleted)
                .ToListAsync();
        }
    }
}
