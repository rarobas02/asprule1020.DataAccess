using asprule1020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.DataAccess.Repository.IRepository
{
    public interface ILaborUnionRepository : IRepository<LaborUnion>
    {
        void UpdateLaborUnion(Guid id, string UnionName, string UnionAddress, string UnionBLR);
    }
}
