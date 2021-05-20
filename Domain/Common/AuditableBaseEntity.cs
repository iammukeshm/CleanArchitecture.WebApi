using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Common
{
    public abstract class AuditableBaseEntity<T> : BaseEntity<T>, IAuditableEntity
    {
        [StringLength(40)] public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        [StringLength(40)] public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    } 
    
    
    public abstract class AuditableBaseEntity:AuditableBaseEntity<int>
    {
        
    }
}
