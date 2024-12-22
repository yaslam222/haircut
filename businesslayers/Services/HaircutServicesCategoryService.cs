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
    public class HaircutServicesCategoryService:GenericServices<HaircutServicesCategory>,IHaircutServicesCategoryService
    {
        private readonly IHaircutServicesCategoryDal _haircutservicescategoryDal;
        public HaircutServicesCategoryService(IHaircutServicesCategoryDal HaircutservicescategoryService):base (HaircutservicescategoryService) 
            
        {
            _haircutservicescategoryDal = HaircutservicescategoryService;
        }
    }
}
