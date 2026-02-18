using asprule1020.DataAccess.Repository.IRepository;
using asprule1020.DataAccess.Data;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asprule1020.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IRegisterRepository Register { get; private set; }
        public IRegionRepository Region { get; private set; }
        public IProvinceRepository Province { get; private set; }
        public ICityMunRepository CityMunicipality { get; private set; }
        public IBarangayRepository Barangay { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Register = new RegisterRepository(_db);
            Region = new RegionRepository(_db);
            Province = new ProvinceRepository(_db);
            CityMunicipality = new CityMunRepository(_db);
            Barangay = new BarangayRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
