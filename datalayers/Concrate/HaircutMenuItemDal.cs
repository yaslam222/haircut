using datalayers.Abstract;
using entitylayers;
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
    }
}
