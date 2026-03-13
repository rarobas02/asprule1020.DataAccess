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

            entity.EstName = obj.EstName;
            entity.EstRegion = obj.EstRegion;
            entity.EstProvince = obj.EstProvince;
            entity.EstCityMun = obj.EstCityMun;
            entity.EstBrgy = obj.EstBrgy;
            entity.EstStreet = obj.EstStreet;

            entity.EstOwnerFirst = obj.EstOwnerFirst;
            entity.EstOwnerMid = obj.EstOwnerMid;
            entity.EstOwnerLast = obj.EstOwnerLast;

            entity.EstMaleCount = obj.EstMaleCount;
            entity.EstFemaleCount = obj.EstFemaleCount;
            entity.EstTotalEmployees = obj.EstMaleCount + obj.EstFemaleCount;

            entity.EstClosureDate = obj.EstClosureDate;
            entity.EstReopeningDate = obj.EstReopeningDate;
            entity.EstFiledClosureDate = obj.EstFiledClosureDate;
            entity.EstReasonForUpdate = obj.EstReasonForUpdate;

            entity.EstSECNumber = obj.EstSECNumber;
            entity.EstSECFile = obj.EstSECFile;
            entity.EstSECDateIssued = obj.EstSECDateIssued;

            entity.EstIsPeza = obj.EstIsPeza;
            entity.EstBisPermitNumber = obj.EstBisPermitNumber;
            entity.EstBisPermitFile = obj.EstBisPermitFile;
            entity.EstBisPermitDateIssued = obj.EstBisPermitDateIssued;
            entity.EstBisPermitValidityDate = obj.EstBisPermitValidityDate;

            entity.EstOwnerValidIDNumber = obj.EstOwnerValidIDNumber;
            entity.EstOwnerValidIDFile = obj.EstOwnerValidIDFile;
            entity.EstOwnerValidIDDateIssued = obj.EstOwnerValidIDDateIssued;
            entity.EstOwnerValidIDDateExpire = obj.EstOwnerValidIDDateExpire;

            entity.EstEvalAssinged = SD.Role_Evaluator;
            entity.EstStatus = SD.StatusForUpdate;
        }
    }
}
