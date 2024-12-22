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
    public class HaircutServiceService:GenericServices<HaircutService>,IHaircutServiceService
    {
        private readonly IHaircutServiceDal _haircutServiceDal;
        public HaircutServiceService(IHaircutServiceDal haircutServiceService):base (haircutServiceService)
        {
            _haircutServiceDal = haircutServiceService;

        }
    }
}
