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
    public class HaircutSupServiceService:GenericServices<HaircutSupService>,IHaircutSupServiceService
    {
        private readonly IHaircutSupServiceDal _hairCutSupServices;
        public HaircutSupServiceService(IHaircutSupServiceDal hairCutSupServices) : base(hairCutSupServices)
        {

            _hairCutSupServices = hairCutSupServices;
        }

        public async Task<IEnumerable<HaircutSupService>> GetByServiceIdAsync(int serviceId)
            => await _hairCutSupServices.GetByServiceIdAsync(serviceId);
    }
}
