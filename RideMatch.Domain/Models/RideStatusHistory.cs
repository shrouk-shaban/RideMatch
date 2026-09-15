using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public class RideStatusHistory
    {
        public int Id { get; set; }
        public RideStatus FromStatus { get; set; }
        public RideStatus ToStatus { get; set; }
        public DateTime ChangedAt { get; set; }
        // Relationship
        public int RideId { get; set; }
        public Ride Ride { get; set; } = null!;
    
    }
}
