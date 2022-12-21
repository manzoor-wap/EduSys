using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Abstract
{
    public interface IAttendanceBusinessObject
    {
        Task<IAttendance> GetAttendance(int id);
        Task<IEnumerable<IAttendance>> GetAttendances();
        Task<bool> CreateAttendance(Attendance attendance);
        Task<bool> DeleteAttendance(Attendance attendance);
        Task<bool> UpdateAttendance(Attendance attendance);
    }
}