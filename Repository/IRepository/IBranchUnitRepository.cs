using asprule1020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.DataAccess.Repository.IRepository
{
    public interface IBranchUnitRepository : IRepository<BranchUnit>
    {
        void UpdateBranchUnit(Guid Id, string rule1020Number, string branchName, string branchAddress);
    }
}
