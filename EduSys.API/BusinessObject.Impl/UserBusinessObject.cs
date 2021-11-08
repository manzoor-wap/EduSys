using BusinessObject.Abstract;
using Datastore.Abstract;
using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessObject.Impl
{
    public class UserBusinessObject : IUserBusinessObject
    {
        public IDataFactory _DataFactory { get; set; }
        public UserBusinessObject(IDataFactory dataFactory)
        {
            _DataFactory = dataFactory;
        }
        public async Task<bool> CreateUser(User user)
        {
            return await _DataFactory.CreateUser(user);
        }

        public async Task<bool> DeleteUser(User user)
        {
            return await _DataFactory.DeleteUser(user);
        }

        public async Task<IUser> GetUser(int id)
        {
            return await _DataFactory.GetUser(id);
        }

        public async Task<IEnumerable<IUser>> GetUsers()
        {
            return await _DataFactory.GetUsers();
        }

        public async Task<bool> UpdateUser(User user)
        {
            return await _DataFactory.UpdateUser(user);
        }
    }
}
