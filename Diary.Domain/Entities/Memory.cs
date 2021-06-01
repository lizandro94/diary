using Diary.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diary.Domain.Entities
{
    public class Memory : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public Guid DiaryId { get; set; }
        public Diary Diary { get; set; }
    }
}
