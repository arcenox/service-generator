using System;

namespace _COMPANYNAME_._PROJECTNAME_._SERVICE_.Domain.Entities.Base
{
    public class EntityTimeStamp : IEntityTimeStamp
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedAt { get; set; }
    }
}
