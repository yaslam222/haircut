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
    public class BeautysServicesService : GenericServices<BeautysServices>, IBeautysServicesService
    {
        private readonly IBeautysServicesDal _beautyservicesRepository;

        public BeautysServicesService(IBeautysServicesDal beautyservicesRepository) : base(beautyservicesRepository)
        {
            _beautyservicesRepository = beautyservicesRepository;
        }
        public async Task<IEnumerable<BeautysServices>> GetByCategoryIdAsync(int categoryId)
        {
            return await _beautyservicesRepository.GetByCategoryIdAsync(categoryId);
        }
    }
}
