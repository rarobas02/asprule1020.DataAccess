using asprule1020.DataAccess.Data;
using asprule1020.DataAccess.Repository.IRepository;
using asprule1020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.DataAccess.Repository
{
    public class RegionRepository : Repository<PhRegion>, IRegionRepository
    {
        private readonly ApplicationDbContext _db;
        public RegionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
