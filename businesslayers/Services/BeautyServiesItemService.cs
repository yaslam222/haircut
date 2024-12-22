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
    public class BeautyServiesItemService:GenericServices<BeautyServiesItem>,IBeautyServiesItemService
    {
        private readonly IBeautyServiesItemDal _beautyServiesItemDal;
        public BeautyServiesItemService(IBeautyServiesItemDal beautyServiesItemservice) : base(beautyServiesItemservice)
        {
            _beautyServiesItemDal = beautyServiesItemservice;
        }
    }
}
