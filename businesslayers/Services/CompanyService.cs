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
    public class CompanyService : GenericServices<Company>, ICompanyService
    {
        private readonly ICompanyDal _companyRepository;

        public CompanyService(ICompanyDal companyRepository) : base(companyRepository)
        {
            _companyRepository = companyRepository;
        }
    }
         
    
}
