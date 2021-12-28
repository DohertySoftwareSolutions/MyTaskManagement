using Mtm = MyTaskManagement.Core.Entities;

namespace MyTaskManagement.DataAccess.Brokers.Databases
{
    public partial class Broker
    {
        public ValueTask<Mtm.Task> CreateTask(Mtm.Task task)
        {
            throw new NotImplementedException();
        }
        public ValueTask<Mtm.Task> DeleteTask(int id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<List<Mtm.Task>> SelectAllTasks()
        {
            throw new NotImplementedException();
        }
        public ValueTask<Mtm.Task> SelectTaskById(int id)
        {
            throw new NotImplementedException();
        }
        public ValueTask<Mtm.Task> UpdateTask(Mtm.Task task)
        {
            throw new NotImplementedException();
        }
    }
}
