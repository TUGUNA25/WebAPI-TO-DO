

using TO_DO.Domain;
using static TO_DO.Domain.Enums;

namespace TO_DO.Application.Users
{
    public class UserUpdateModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Status Status { get; set; }
    }
}
