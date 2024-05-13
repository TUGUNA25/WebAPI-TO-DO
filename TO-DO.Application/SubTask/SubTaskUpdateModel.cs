
using TO_DO.Domain;
using static TO_DO.Domain.Enums;

namespace TO_DO.Application.SubTask
{
    public class SubTaskUpdateModel
    {
        public string Title { get; set; }
        public int TodoItemId { get; set; }
        public Status Status { get; set; }
    }
}
