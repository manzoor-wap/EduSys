using Datastore.Abstract.Models.Abstract;
using Datastore.Abstract.Models.Impl;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessObject.Abstract
{
    public interface IUserBusinessObject
    {
        Task<IUser> GetUser(int id);
        Task<IEnumerable<IUser>> GetUsers();
        Task<bool> CreateUser(User user);
        Task<bool> DeleteUser(User user);
        Task<bool> UpdateUser(User user);
    }
}
