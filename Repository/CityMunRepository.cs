using asprule1020.DataAccess.Data;
using asprule1020.DataAccess.Repository.IRepository;
using asprule1020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.DataAccess.Repository
{
    public class CityMunRepository : Repository<PhCityMun>, ICityMunRepository
    {
        private readonly ApplicationDbContext _db;
        public CityMunRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
