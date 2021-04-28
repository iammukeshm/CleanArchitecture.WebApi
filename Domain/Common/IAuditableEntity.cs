using System;

namespace Domain.Common
{
    public interface IAuditableEntity<T> : IAuditableEntity
    {
        public T Id { get; set; }
    }

    public interface IAuditableEntity
    {
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}