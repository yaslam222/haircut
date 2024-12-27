using businesslayers.Interfaces;
using datalayers.Abstract;
using datalayers.Concrate;
using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayers.Services
{
    public class HaircutServiceService:GenericServices<HaircutService>,IHaircutServiceService
    {
        private readonly IHaircutServiceDal _haircutServices;
        public HaircutServiceService(IHaircutServiceDal haircutServices) : base(haircutServices)
        {

            _haircutServices = haircutServices;
        }
       
        public async Task<IEnumerable<HaircutService>> GetServicesByCategoryAsync(int categoryId)
            => await _haircutServices.GetServicesByCategoryAsync(categoryId);
    }
}
