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
    public class BeautyCardInfoService:GenericServices<BeautyCardInfo>,IBeautyCardInfoService
    {
        private readonly IBeautyCardInfoDal _beautyCardInfoRepository;

        public BeautyCardInfoService(IBeautyCardInfoDal beautyCardInfoRepository) : base(beautyCardInfoRepository)
        {
            _beautyCardInfoRepository = beautyCardInfoRepository;
        }
    }
}
