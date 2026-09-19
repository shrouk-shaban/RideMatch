using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public interface  IAuditableEntity
    {
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
