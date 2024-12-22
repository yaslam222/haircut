using datalayers.Abstract;
using entitylayers;
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
    }
}
