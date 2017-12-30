using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LifeLine.Core.Interfaces
{
    public interface IBloodDonorRepository
    {
        void Add(BloodDonor b);
        void Edit(BloodDonor b);
        void Remove(string BloodDonorID);
        IEnumerable<BloodDonor> GetBloodDonors();
        BloodDonor FindById(string BloodDonorID);
    }
}