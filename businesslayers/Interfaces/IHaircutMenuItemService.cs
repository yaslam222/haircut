using entitylayers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businesslayers.Interfaces
{
    public interface IHaircutMenuItemService : IGenericServices<HaircutMenuItem>
    {
        Task<IEnumerable<HaircutMenuItem>> GetAllWithCategoryAsync();
    }
}
