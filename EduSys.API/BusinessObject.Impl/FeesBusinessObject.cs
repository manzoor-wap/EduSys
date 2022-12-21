using BusinessObject.Abstract;
using Datastore.Abstract;
using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Impl
{
    public class FeesBusinessObject : IFeesBusinessObject
    {
        public IDataFactory _DataFactory { get; set; }
        public FeesBusinessObject(IDataFactory dataFactory)
        {
            _DataFactory = dataFactory;
        }
        public async Task<bool> CreateFees(Fees fees)
        {
            return await _DataFactory.CreateFees(fees);
        }

        public async Task<bool> DeleteFees(Fees fees)
        {
            return await _DataFactory.DeleteFees(fees);
        }

        public async Task<IFees> GetFees(int id)
        {
            return await _DataFactory.GetFees(id);
        }

        public async Task<IEnumerable<IFees>> GetFeess()
        {
            return await _DataFactory.GetFeess();
        }

        public async Task<bool> UpdateFees(Fees fees)
        {
            return await _DataFactory.UpdateFees(fees);
        }
    }
}

