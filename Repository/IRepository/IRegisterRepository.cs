using asprule1020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.DataAccess.Repository.IRepository
{
    public interface IRegisterRepository: IRepository<Register>
    {
            void UpdateEvaluator(Register register, string evaluatorFullName);
            void UpdatePoHead(Register obj, string evaluatorFullName);
            void UpdateClientDetails(Register obj, string evaluatorFullName);
            void Save();
    }
}
