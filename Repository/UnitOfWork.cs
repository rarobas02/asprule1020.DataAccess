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

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Register = new RegisterRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
