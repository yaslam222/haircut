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
    public class HaircutMenuCategoryDal:GenericRepository<HaircutMenuCategory>,IHaircutMenuCategoryDal
    {
        private new readonly context _context;
        public HaircutMenuCategoryDal(context context) : base(context)
        {
            _context = context;
        }
    }
}
