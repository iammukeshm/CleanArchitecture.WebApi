using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Common
{
    public abstract class BaseEntity<T>:IEntity<T>
    {
        [Key] public virtual T Id { get; set; }
    }

    public abstract class BaseEntity:IEntity<int>
    {
        public virtual int Id { get; set; }
    }
}