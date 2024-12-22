using datalayers.Abstract;
using entitylayers;
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
    }
}
