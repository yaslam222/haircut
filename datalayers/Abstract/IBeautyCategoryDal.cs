﻿using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayers.Abstract
{
    public interface IBeautyCategoryDal:IGenericRepository<BeautyCategory>
    {  
        // Returns a single BeautyCategory with its associated BeautyItems


        // Returns a collection of BeautyItems for a specific category


        // Adds a new BeautyItem to a category
    }
}
