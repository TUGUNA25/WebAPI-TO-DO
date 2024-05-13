using Mapster;
using System.Security.Claims;
using TO_DO.Application.SubTask;
using TO_DO.Application.TO_DO;
using TO_DO.Application.User;
using TO_DO.Application.Users;
using TO_DO.Domain;
using TO_DO.Domain.SubTask;
using TO_DO.Domain.TO_DOs;
using TO_DO.Domain.Userss;
namespace TO_DO.API.Infrastructure.Mappings
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection services)
        {
            TypeAdapterConfig<UserRequestModel, Userss>
                .NewConfig()
                .Map(dest => dest.PasswordHash, src => src.Password)
                .Map(dest => dest.CreatedAt, src => DateTime.Now)
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .Map(dest => dest.Status, src => Enums.Status.Active)
                .TwoWays();
            TypeAdapterConfig<UserRequestModel, UserResponseModel>
                .NewConfig()
                .TwoWays();
            TypeAdapterConfig<UserUpdateModel, Userss>
                .NewConfig()
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .Map(dest => dest.PasswordHash, src => src.Password)
                .TwoWays();
            TypeAdapterConfig<TO_DORequestModel, ToDos>
                .NewConfig()
                .Map(dest => dest.CreatedAt, src => DateTime.Now)
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .Map(dest => dest.StatusEnum, src => Enums.Status.Active)
                .Map(dest => dest.Subtasks, src => new List<Subtask>())
                .TwoWays();
            TypeAdapterConfig<TO_DORequestModel,TO_DOResponseModel>
                .NewConfig()
                .TwoWays();
            TypeAdapterConfig<TO_DOUpdateModel,ToDos>
                .NewConfig()
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .TwoWays();
            TypeAdapterConfig<SubTaskRequestModel, Subtask>
                .NewConfig()
                .Map(dest => dest.CreatedAt, src => DateTime.Now)
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .Map(dest => dest.Status, src => Enums.Status.Active)
                .TwoWays();
            TypeAdapterConfig<SubTaskRequestModel, SubTaskResponseModel>
                .NewConfig()
                .TwoWays();
            TypeAdapterConfig<SubTaskUpdateModel, Subtask>
                .NewConfig()
                .Map(dest => dest.ModifiedAt, src => DateTime.Now)
                .TwoWays();

        }
    }
}
