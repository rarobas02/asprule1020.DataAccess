using asprule1020.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace asprule1020.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IRegisterRepository Register { get; }
        IRegionRepository Region { get; }
        IProvinceRepository Province { get; }  
        ICityMunRepository CityMunicipality { get; }
        IBarangayRepository Barangay { get; }
        IUpdateRepository UpdateRegistration { get;  }
        IBranchUnitRepository BranchUnit { get;  }
        ILaborUnionRepository LaborUnion { get;  }
        IEvaluationChecklistRepository EvaluationChecklist { get; }
        IEvaluationRemarkRepository EvaluationRemark { get; }
        IApplicationUserRepository ApplicationUser { get; }
        void Save();
    }
}
