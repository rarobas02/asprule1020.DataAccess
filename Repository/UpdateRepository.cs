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
    public class UpdateRepository : Repository<Register>, IUpdateRepository
    {
        private readonly ApplicationDbContext _db;
        public UpdateRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void UpdateRegistration(Register obj)
        {
            var entity = _db.Registers.FirstOrDefault(u => u.Id == obj.Id);
            if (entity == null)
                return;

            //entity. = evaluatorFullName;
        }
    }
}
