
using TO_DO.Domain.SubTask;
using static TO_DO.Domain.Enums;

namespace TO_DO.Application.TO_DO
{
    public class TO_DOUpdateModel
    {
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime? TargetCompletionDate { get; set; }
        public int OwnerId { get; set; }
        public Status StatusEnum { get; set; }
    }
}
