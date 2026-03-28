using asprule1020.DataAccess.Data;
using asprule1020.DataAccess.Repository.IRepository;
using asprule1020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.DataAccess.Repository
{
    public class EvaluationRemarkRepository : Repository<EvaluationRemark>, IEvaluationRemarkRepository
    {
        private ApplicationDbContext _db;
        public EvaluationRemarkRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
