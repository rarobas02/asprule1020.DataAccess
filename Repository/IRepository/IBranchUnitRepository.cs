using asprule1020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.DataAccess.Repository.IRepository
{
    public interface IBranchUnitRepository
    {
        void AddLaborUnion(LaborUnion register);
        void UpdateLaborUnion(Register register);
        void DeleteLaborUnion(Register register);
    }
}
