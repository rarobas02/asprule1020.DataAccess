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
    public class BranchUnitRepository : Repository<BranchUnit>, IBranchUnitRepository
    {
        private readonly ApplicationDbContext _db;
        public BranchUnitRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void UpdateBranchUnit(BranchUnit obj)
        {
            var entity = _db.BranchUnits.FirstOrDefault(u => u.Id == obj.Id);
            if (entity == null)
                return;
            entity.Rule1020Number = obj.Rule1020Number;
            entity.BranchName = obj.BranchName;
            entity.BranchAddress = obj.BranchAddress;
        }

    }
}
