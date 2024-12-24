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
        private readonly IHaircutMenuItemDal _haircutmenuitemDal;
        public HaircutMenuItemService(IHaircutMenuItemDal haircutmenuitemService) : base(haircutmenuitemService)
        {
            _haircutmenuitemDal = haircutmenuitemService;



        }
        public async Task<IEnumerable<HaircutMenuItem>> GetAllWithCategoryAsync()
        {
            return await _haircutmenuitemDal.GetAllWithCategoryAsync();
        }
    }   

}
