using static TO_DO.Domain.Enums;

namespace TO_DO.Application.SubTask
{
    public class SubTaskResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TodoItemId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Status Status { get; set; }
    }
}
