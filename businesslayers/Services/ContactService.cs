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
    public class ContactService:GenericServices<Contact>,IContactService
    {
        private readonly IContactDal _contactRepository;

        public ContactService(IContactDal contactRepository) : base(contactRepository)
        {
            _contactRepository = contactRepository;
        }
    }
}
