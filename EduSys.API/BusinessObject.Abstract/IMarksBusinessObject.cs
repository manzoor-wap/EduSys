using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Abstract
{
    public interface IMarksBusinessObject
    {
        Task<IMarks> GetMarks(int id);
        Task<IEnumerable<IMarks>> GetMarkss();
        Task<bool> CreateMarks(Marks marks);
        Task<bool> DeleteMarks(Marks marks);
        Task<bool> UpdateMarks(Marks marks);
    }
}
