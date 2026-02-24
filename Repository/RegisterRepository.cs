using asprule1020.DataAccess.Repository.IRepository;
using asprule1020.Models;
using asprule1020.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;
using asprule1020.Utility;

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

            entity.EstEvalName = evaluatorFullName;
            entity.EstEvalDate = DateTime.Now;
            entity.EstEvalRemarks = changes.EstEvalRemarks;
            entity.EstEvalAssinged = SD.Role_Po_Head;
            entity.EstStatus = changes.EstStatus;
        }
        public void UpdatePoHead(Register obj, string evaluatorFullName)
        {
            var objFromDb = _db.Registers.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.EstPoHeadName = evaluatorFullName;
                objFromDb.EstPoHeadEvalDate = DateTime.Now;
                objFromDb.EstPoHeadRemarks = obj.EstPoHeadRemarks;
            }
            else
            {
                return;
            }
        }
    }
}
