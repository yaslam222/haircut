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
        private readonly IHaircutMenuCategoryDal _haircutmenucategoryRepository;

        public HaircutMenuCategoryService(IHaircutMenuCategoryDal haircutmenucategoryRepository) : base(haircutmenucategoryRepository)
        {
            _haircutmenucategoryRepository = haircutmenucategoryRepository;
        }
    }
}
