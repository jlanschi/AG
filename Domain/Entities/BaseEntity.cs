using System.Collections.Generic;

namespace Autoglass.Domain.Entities
{
    public abstract class BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual int Situacao { get; protected set; }
    }
}
