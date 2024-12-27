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
    public class HaircutServiceDal:GenericRepository<HaircutService>,IHaircutServiceDal
    {
        public HaircutServiceDal(context _context) : base(_context)
        {
        }
       

        public async Task<IEnumerable<HaircutService>> GetServicesByCategoryAsync(int categoryId)
        {
            return await _context.HaircutServices
                .Where(h => h.ServiceCategoryId == categoryId)
                .ToListAsync();
        }
    }
}
