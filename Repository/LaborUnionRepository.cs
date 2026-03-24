using asprule1020.DataAccess.Data;
using asprule1020.DataAccess.Repository.IRepository;
using asprule1020.Models;
using asprule1020.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace asprule1020.DataAccess.Repository
{
    public class LaborUnionRepository : Repository<LaborUnion>, ILaborUnionRepository
    {
        private readonly ApplicationDbContext _db;
        public LaborUnionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void UpdateLaborUnion(Guid id, string UnionName, string UnionAddress, string UnionBLR)
        {
            var entity = _db.LaborUnions.FirstOrDefault(u => u.Id == id);
            if (entity == null)
                return;
            entity.UnionName = UnionName;
            entity.UnionBLR = UnionBLR;
            entity.UnionAddress = UnionAddress;
        }
    }
}
