using Diary.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diary.Domain.Entities
{
    public class Diary : AuditableEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Memory> Memories { get; set; }
    }
}
