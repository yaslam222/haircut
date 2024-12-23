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
    public class HaircutSupServiceDal:GenericRepository<HaircutSupService>,IHaircutSupServiceDal
    {

        private new readonly context _context;

        public HaircutSupServiceDal(context __context) : base(__context)
        {
            _context = __context;
        }

        public async Task<IEnumerable<HaircutSupService>> GetByServiceIdAsync(int serviceId)
        {
            return await _context.HaircutSupServices
                .Where(s => s.ServiceId == serviceId)
                .ToListAsync();
        }

    }
}
