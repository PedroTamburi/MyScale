using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyScale.Domain.Base
{
    public abstract class BaseEntity<TId> : IBaseEntity
    {
        public TId Id { get; private set; }

        public BaseEntity(TId id) => Id = id;

        public BaseEntity()
        {
        }
    }
}
