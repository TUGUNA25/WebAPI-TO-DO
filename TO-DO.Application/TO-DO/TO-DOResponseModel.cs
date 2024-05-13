using TO_DO.Domain;
using TO_DO.Domain.SubTask;
using static TO_DO.Domain.Enums;

namespace TO_DO.Application.TO_DO
{
    public class TO_DOResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime? TargetCompletionDate { get; set; }
        public int OwnerId { get; set; }


        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Status StatusEnum { get; set; }
    }
}
