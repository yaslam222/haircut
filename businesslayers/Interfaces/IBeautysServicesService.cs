using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayers.Interfaces
{
    public interface IBeautysServicesService : IGenericServices<BeautysServices>
    {
        Task<IEnumerable<BeautysServices>> GetByCategoryIdAsync(int categoryId);
    }
}
