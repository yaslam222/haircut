using datalayers.Abstract;
using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayers.Concrate
{
    public class CompanyDal:GenericRepository<Company>,ICompanyDal
    {
        public CompanyDal(context _context) : base(_context)
        {
        }
    }
}
