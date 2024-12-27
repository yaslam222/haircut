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
    public class HaircutMenuItemService:GenericServices<HaircutMenuItem>,IHaircutMenuItemService
    {
        private readonly IHaircutMenuItemDal _haircutmenuitemRepository;
        public HaircutMenuItemService(IHaircutMenuItemDal haircutmenuitemRepository) : base(haircutmenuitemRepository)
        {

            _haircutmenuitemRepository = haircutmenuitemRepository;
        }



        public async Task<IEnumerable<HaircutMenuItem>> GetAllWithCategoryAsync()
        {
            return await _haircutmenuitemRepository.GetAllWithCategoryAsync();
        }
    }   

}
