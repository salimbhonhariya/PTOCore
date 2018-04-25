using System;

namespace PTOCore
{
    public interface IAuditedEntity
        {
            string CreatedBy { get; set; }
            DateTime CreatedAt { get; set; }
            string LastModifiedBy { get; set; }
            DateTime LastModifiedAt { get; set; }
        }
}
