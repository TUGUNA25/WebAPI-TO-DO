using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TO_DO.Domain;
using TO_DO.Domain.SubTask;

namespace TO_DO.Application.TO_DO
{
    public class TO_DORequestModel
    {
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime? TargetCompletionDate { get; set; }
        public int OwnerId { get; set; }
    }
}
