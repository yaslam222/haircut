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
    public class BeautyCategoryDal : GenericRepository<BeautyCategory>, IBeautyCategoryDal
    {

        public BeautyCategoryDal(context _context) : base(_context)
        {

        }
        
        






    }
}
