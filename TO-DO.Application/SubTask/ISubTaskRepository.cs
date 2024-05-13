using TO_DO.Domain.SubTask;

namespace TO_DO.Application.SubTask
{
    public interface ISubTaskRepository
    {
        Task<Subtask> GetSubTaskIdAsync(CancellationToken cancellationToken, int Id);
        Task CreateSubTaskAsync(CancellationToken cancellationToken, Subtask task);
        Task UpdateSubTasksync(CancellationToken cancellationToken, Subtask task);
        Task DeleteSubTaskAsync(CancellationToken cancellationToken, int Id);
        Task<bool> Exists(CancellationToken cancellationToken, int id);
    }
}
