using asprule1020.DataAccess.Repository.IRepository;
using asprule1020.Models;
using asprule1020.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.DataAccess.Repository
{
    public class RegisterRepository : Repository<Register>, IRegisterRepository
    {
        private readonly ApplicationDbContext _db;
        public RegisterRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }
        public void Update(Register obj)
        {
            _db.Registers.Update(obj);
        }
    }
}
