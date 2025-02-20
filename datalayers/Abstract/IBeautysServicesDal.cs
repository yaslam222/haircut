﻿using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayers.Abstract
{
    public interface IBeautysServicesDal : IGenericRepository<BeautysServices>
    {
        Task<IEnumerable<BeautysServices>> GetByCategoryIdAsync(int categoryId);
    }
}
