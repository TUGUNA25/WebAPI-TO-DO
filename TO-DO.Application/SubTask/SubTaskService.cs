﻿using Mapster;
using TO_DO.Domain.SubTask;

namespace TO_DO.Application.SubTask
{
    public class SubTaskService : ISubTaskService
    {
        private readonly ISubTaskRepository _repository;

        public SubTaskService(ISubTaskRepository repository) {
            _repository = repository;
        }

        public async Task CreateSubTaskAsync(CancellationToken cancellationToken, SubTaskRequestModel userRequest)
        {
            var task = userRequest.Adapt<Subtask>();
            await _repository.CreateSubTaskAsync(cancellationToken, task);
        }

        public async Task DeleteSubTaskAsync(CancellationToken cancellationToken, int Id)
        {
            if (!await _repository.Exists(cancellationToken, Id))
                throw new Exception(); // shesacvlelai
            await _repository.DeleteSubTaskAsync(cancellationToken, Id);
        }

        public async Task<SubTaskResponseModel> GetSubTaskAsync(CancellationToken cancellationToken, int Id)
        {
            var result = await _repository.GetSubTaskIdAsync(cancellationToken, Id);
            if (result == null)
                throw new Exception();// shesacleleia
            else
                return result.Adapt<SubTaskResponseModel>();
        }

        public async Task UpdateSubTaskAsync(CancellationToken cancellationToken, int Id, SubTaskUpdateModel userRequest)
        {
            if(!await _repository.Exists(cancellationToken,Id))
                throw new Exception(); // shesacvlelia
            var task = userRequest.Adapt<Subtask>();
            task.Id = Id;
            await _repository.UpdateSubTasksync(cancellationToken, task);
        }
    }
}
