﻿using businesslayers.Interfaces;
using datalayers.Abstract;
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
        private readonly IHaircutSupServiceDal _haircutsupserviceDal;
        public HaircutSupServiceService(IHaircutSupServiceDal haircutsupserviceService) :base(haircutsupserviceService)
        {
            _haircutsupserviceDal = haircutsupserviceService;
        }
    }
}