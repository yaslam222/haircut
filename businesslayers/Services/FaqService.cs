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
    public class FaqService:GenericServices<Faq>,IFaqService
    {
        private readonly IFaqDal _faqDal;
        public FaqService(IFaqDal faqservice):base(faqservice)
        {
            _faqDal = faqservice;
        }
    }
}
