using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public class RideAssignment
    {
        public int Id { get; set; }
        public DateTime OfferedAt { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime? RespondedAt { get; set; }

        public AssignmentStatus Status { get; set; }

        // Relationships
        public int RideId { get; set; }
        public Ride Ride { get; set; } = null!;
        public int DriverProfileId { get; set; }
        public DriverProfile Driver { get; set; } = null!;
      //  public RideOffer? RideOffer { get; set; }
    }
}
