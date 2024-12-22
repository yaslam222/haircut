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
    public class BeautyItemService : GenericServices<BeautyItem>, IBeautyItemService
    {
        private readonly IBeautyItemDal _beautyItemDal;
        public BeautyItemService(IBeautyItemDal beautyItemService) : base(beautyItemService)
        {
            _beautyItemDal = beautyItemService;
        }

    }
}
