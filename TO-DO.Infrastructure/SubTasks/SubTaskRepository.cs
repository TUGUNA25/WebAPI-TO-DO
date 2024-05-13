using Microsoft.EntityFrameworkCore;
using TO_DO.Application.SubTask;
using TO_DO.Domain;
using TO_DO.Domain.SubTask;
using TO_DO.Persistence.Context;

namespace TO_DO.Infrastructure.SubTasks
{
    public class SubTaskRepository : BaseRepository<Subtask>, ISubTaskRepository
    {
        public SubTaskRepository(TO_DOContext context) : base(context)
        {
        }

        public async Task CreateSubTaskAsync(CancellationToken cancellationToken, Subtask task)
        { 
            await base.AddAsync(cancellationToken, task);
        }

        public async Task DeleteSubTaskAsync(CancellationToken cancellationToken, int Id)
        {
            await base.RemoveAsync(cancellationToken, Id);
        }

        public async Task<bool> Exists(CancellationToken cancellationToken, int id)
        {
            return await base.AnyAsync(cancellationToken, x => x.Id == id);
        }

        public async Task<Subtask> GetSubTaskIdAsync(CancellationToken cancellationToken, int Id)
        {
            return await base.GetAsync(cancellationToken, Id);
        }

        public async Task UpdateSubTasksync(CancellationToken cancellationToken, Subtask task)
        {
            await base.UpdateAsync(cancellationToken, task);
        }
    }
}
