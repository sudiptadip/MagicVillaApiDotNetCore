using MagicVilla_VillaAPi.Models;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPi.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> Update(VillaNumber entity);
    }
}
