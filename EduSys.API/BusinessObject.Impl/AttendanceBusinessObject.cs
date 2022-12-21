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
    public class AttendanceBusinessObject : IAttendanceBusinessObject
    {
        public IDataFactory _DataFactory { get; set; }
        public AttendanceBusinessObject(IDataFactory dataFactory)
        {
            _DataFactory = dataFactory;
        }
        public async Task<bool> CreateAttendance(Attendance attendance)
        {
            return await _DataFactory.CreateAttendance(attendance);
        }

        public async Task<bool> DeleteAttendance(Attendance attendance)
        {
            return await _DataFactory.DeleteAttendance(attendance);
        }

        public async Task<IAttendance> GetAttendance(int id)
        {
            return await _DataFactory.GetAttendance(id);
        }

        public async Task<IEnumerable<IAttendance>> GetAttendances()
        {
            return await _DataFactory.GetAttendances();
        }

        public async Task<bool> UpdateAttendance(Attendance attendance)
        {
            return await _DataFactory.UpdateAttendance(attendance);
        }
    }
}
