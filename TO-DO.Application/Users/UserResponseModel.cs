using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO_DO.Domain;
using static TO_DO.Domain.Enums;

namespace TO_DO.Application.User
{
    public class UserResponseModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Status Status { get; set; }
    }
}
