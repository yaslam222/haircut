using datalayers.Abstract;
using entitylayers;
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
    }
}
