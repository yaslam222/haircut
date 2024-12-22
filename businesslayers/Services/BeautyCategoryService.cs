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
    public class BeautyCategoryService : GenericServices<BeautyCategory>, IBeautyCategoryService
    {
        private readonly IBeautyCategoryDal _beautyCategoryDal;
        public BeautyCategoryService(IBeautyCategoryDal Beautycategoryservice) : base(Beautycategoryservice)
        {
            _beautyCategoryDal = Beautycategoryservice;
        }
    }   
}
