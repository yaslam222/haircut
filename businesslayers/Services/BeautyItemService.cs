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
    public class BeautyItemService : GenericServices<BeautyItem>, IBeautyItemService
    {
        private readonly IBeautyItemDal _beautyitemRepository;
        private readonly IBeautyCategoryDal _categoryService; // Inject category service

        public BeautyItemService(IBeautyItemDal beautyitemRepository, IBeautyCategoryDal categoryService) : base(beautyitemRepository)
        {
            _beautyitemRepository = beautyitemRepository;
            _categoryService = categoryService;
        }
        public async Task<IEnumerable<BeautyItem>> GetByCategoryIdAsync(int categoryId)
        {
            return await _beautyitemRepository.GetByCategoryIdAsync(categoryId);
        }

    }
}
