using MagicVilla_VillaAPi.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPi.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> Update(Villa entity);
    }
}
