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
    public class BeautysServicesService : GenericServices<BeautysServices>, IBeautysServicesService
    {
        private readonly IBeautysServicesDal _beautysServicesDal;
        public BeautysServicesService(IBeautysServicesDal beautysServicesService) : base(beautysServicesService)
        {
            _beautysServicesDal = beautysServicesService;
        }
    }
}
