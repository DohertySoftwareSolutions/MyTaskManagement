using Mtm = MyTaskManagement.Core.Entities;

namespace MyTaskManagement.DataAccess.Brokers.Databases
{
    public partial interface IBroker
    {
        ValueTask<Mtm.Task> SelectTaskById(int id);
        ValueTask<List<Mtm.Task>> SelectAllTasks();
        ValueTask<Mtm.Task> CreateTask(Mtm.Task task);
        ValueTask<Mtm.Task> UpdateTask(Mtm.Task task);
        ValueTask<Mtm.Task> DeleteTask(int id);
    }
}
