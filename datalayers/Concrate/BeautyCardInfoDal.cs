﻿using datalayers.Abstract;
using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalayers.Concrate
{
    public class BeautyCardInfoDal:GenericRepository<BeautyCardInfo>,IBeautyCardInfoDal
    {
        public BeautyCardInfoDal(context _context) : base(_context)
        {
        }
    }
}