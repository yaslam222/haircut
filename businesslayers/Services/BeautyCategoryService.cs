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
        private readonly IBeautyCategoryDal _beautycategoryRepository;
        public BeautyCategoryService(IBeautyCategoryDal categoryRepository) : base(categoryRepository)
        {

            _beautycategoryRepository = categoryRepository;
        }
    }   
}
