using businesslayers.Interfaces;
using datalayers.Abstract;
using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayers.Services
{
    public class HaircutMenuCategoryService:GenericServices<HaircutMenuCategory>,IHaircutMenuCategoryService
    {
        private readonly IHaircutMenuCategoryDal _haircutcategoryDal;
        public HaircutMenuCategoryService(IHaircutMenuCategoryDal haircutcategoryService):base(haircutcategoryService)
        {
            _haircutcategoryDal = haircutcategoryService;
        }
    }
}
