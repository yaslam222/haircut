using datalayers.Abstract;
using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayers.Concrate
{
    public class ContactDal:GenericRepository<Contact>,IContactDal
    {
        public ContactDal(context _context) : base(_context)
        {
        }
    }
}
