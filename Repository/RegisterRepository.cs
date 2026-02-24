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
        public void UpdateEvaluator(Register changes, string evaluatorFullName)
        {
            var entity = _db.Registers.FirstOrDefault(u => u.Id == changes.Id);
            if (entity == null) return;

            entity.EstEvalName = string.IsNullOrWhiteSpace(evaluatorFullName)
    ? entity.EstEvalName
    : evaluatorFullName;
            entity.EstEvalDate = DateTime.Now;
            entity.EstEvalRemarks = changes.EstEvalRemarks;
            entity.EstEvalAssinged = changes.EstEvalAssinged;
            entity.EstStatus = changes.EstStatus;
        }
        public void UpdatePoHead(Register obj)
        {
            _db.Registers.Update(obj);
            var objFromDb = _db.Registers.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.EstPoHeadName = obj.EstPoHeadName;
                objFromDb.EstPoHeadEvalDate = obj.EstPoHeadEvalDate;
                objFromDb.EstPoHeadRemarks = obj.EstPoHeadRemarks;
            }
        }
    }
}
