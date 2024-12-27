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
    public class HairCutTeammemberService:GenericServices<HairCutTeammember>,IHairCutTeammemberService
    {
        private readonly IHairCutTeammemberDal _hairCutTeammember;

        public HairCutTeammemberService(IHairCutTeammemberDal hairCutTeammember) : base(hairCutTeammember)
        {
            _hairCutTeammember = hairCutTeammember;
        }
    }
}
