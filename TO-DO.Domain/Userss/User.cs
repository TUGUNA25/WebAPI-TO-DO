using TO_DO.Domain.TO_DOs;
using static TO_DO.Domain.Enums;

namespace TO_DO.Domain.Userss
{
    public class Userss
    {  
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Status Status { get; set; }

        // navigation
        public List<ToDos> ToDoes { get; set; }
      
    }
 
}
