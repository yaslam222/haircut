﻿using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayers.Abstract
{
    public interface IHaircutMenuCategoryDal : IGenericRepository<HaircutMenuCategory>
    {
        Task<IEnumerable<HaircutMenuItem>> GetHaircutMenuItemsByCategoryIdAsync(int categoryId);
    }
}