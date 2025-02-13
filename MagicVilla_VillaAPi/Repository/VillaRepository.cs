using MagicVilla_VillaAPi.Data;
using MagicVilla_VillaAPi.Models;
using MagicVilla_VillaAPi.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MagicVilla_VillaAPi.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public async Task<Villa> Update(Villa entity)
        {
            _db.Villas.Update(entity);
             await _db.SaveChangesAsync();
            return entity;
        }
    }
}
