using asprule1020.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace asprule1020.DataAccess.Repository.IRepository
{
    public interface IRegisterRepository: IRepository<Register>
    {
            void UpdateEvaluator(Register register, string evaluatorFullName);
            void UpdatePoHead(Register obj, string evaluatorFullName, string rule1020Id);
            void UpdateClientDetails(Register obj, string evaluatorFullName);
            void ApprovedEmailSendStatus(bool emailSendStatus, DateTime emailStatusSendDate, Guid id);
            void Save();
    }
}
