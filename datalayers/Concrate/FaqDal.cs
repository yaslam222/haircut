using datalayers.Abstract;
using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayers.Concrate
{
    public class FaqDal:GenericRepository<Faq>,IFaqDal
    {
        public FaqDal(context _context) : base(_context)
        {
        }
    }
}
