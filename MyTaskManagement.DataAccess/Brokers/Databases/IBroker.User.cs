using Mtm = MyTaskManagement.Core.Entities;

namespace MyTaskManagement.DataAccess.Brokers.Databases
{
    public partial interface IBroker
    {
        ValueTask<Mtm.User> SelectUserById(int id);
        ValueTask<List<Mtm.User>> SelectAllUsers();
        ValueTask<Mtm.User> CreateUser(Mtm.User task);
        ValueTask<Mtm.User> UpdateUser(Mtm.User task);
        ValueTask<Mtm.User> DeleteUser(int id);
    }
}
