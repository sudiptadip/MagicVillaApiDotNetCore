using MagicVilla_VillaAPi.Data;
using MagicVilla_VillaAPi.Models;
using MagicVilla_VillaAPi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPi.Repository
{
    public class VillaNumberRepository : Repository<VillaNumber>, IVillaNumberRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaNumberRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public async Task<VillaNumber> Update(VillaNumber entity)
        {
            _db.VillaNumbers.Update(entity);
             await _db.SaveChangesAsync();
            return entity;
        }
    }
}
