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
        void Save();
    }
}
