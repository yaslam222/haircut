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
    public class HaircutServicesCategoryDal:GenericRepository<HaircutServicesCategory>,IHaircutServicesCategoryDal
    {
        private new readonly context _context;

        public HaircutServicesCategoryDal(context context) : base (context)
        {
            _context = context;
        }
    }
}
