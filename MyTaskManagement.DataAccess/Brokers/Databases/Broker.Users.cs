using Mtm = MyTaskManagement.Core.Entities;

namespace MyTaskManagement.DataAccess.Brokers.Databases
{
    public partial class Broker
    {
        public ValueTask<Mtm.User> CreateUser(Mtm.User task)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Mtm.User> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<List<Mtm.User>> SelectAllUsers()
        {
            throw new NotImplementedException();
        }

        public ValueTask<Mtm.User> SelectUserById(int id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Mtm.User> UpdateUser(Mtm.User task)
        {
            throw new NotImplementedException();
        }
    }
}
