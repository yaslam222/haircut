﻿using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayers.Abstract
{
    public interface IHaircutServiceDal : IGenericRepository<HaircutService>
    {
        Task<HaircutService?> GetServiceWithSubServicesAsync(int id);
        Task<IEnumerable<HaircutService>> GetServicesByCategoryAsync(int categoryId);
    }
}