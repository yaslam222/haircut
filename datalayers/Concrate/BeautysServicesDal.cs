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
    public class BeautysServicesDal:GenericRepository<BeautysServices>,IBeautysServicesDal
    {
        public BeautysServicesDal(context _context) : base(_context)
        {
        }

        public async Task<IEnumerable<BeautysServices>> GetByCategoryIdAsync(int categoryId)
        {
            return await _dbSet
                .Where(item => item.BeautyServicesItemId == categoryId && !item.IsDeleted)
                .ToListAsync();
        }
    }
}
