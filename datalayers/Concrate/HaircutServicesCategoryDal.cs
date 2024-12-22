using datalayers.Abstract;
using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayers.Concrate
{
    public class HaircutServicesCategoryDal:GenericRepository<HaircutServicesCategory>,IHaircutServicesCategoryDal
    {
        public HaircutServicesCategoryDal(context _context) : base(_context)
        {
        }
    }
}
