using Datastore.Abstract.Models;
using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Datastore.Abstract
{
    public interface IDataFactory
    {
        Task<IUser> GetUser(int id);
        Task<IEnumerable<IUser>> GetUsers();
        Task<bool> CreateUser(User user);
        Task<bool> DeleteUser(User user);
        Task<bool> UpdateUser(User user);
    }
}
