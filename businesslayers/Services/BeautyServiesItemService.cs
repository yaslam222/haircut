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
    public class BeautyServiesItemService:GenericServices<BeautyServiesItem>,IBeautyServiesItemService
    {
        private readonly IBeautyServiesItemDal _BeautyserviceitemRepository;

        public BeautyServiesItemService(IBeautyServiesItemDal BeautyserviceitemRepository) : base(BeautyserviceitemRepository)
        {
            _BeautyserviceitemRepository = BeautyserviceitemRepository;
        }
    }
}
