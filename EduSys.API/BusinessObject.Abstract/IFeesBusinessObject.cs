using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Abstract
{
    public interface IFeesBusinessObject
    {
        Task<IFees> GetFees(int id);
        Task<IEnumerable<IFees>> GetFeess();
        Task<bool> CreateFees(Fees fees);
        Task<bool> DeleteFees(Fees fees);
        Task<bool> UpdateFees(Fees fees);
    }
}
