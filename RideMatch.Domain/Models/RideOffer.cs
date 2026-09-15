using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public class RideOffer
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public OfferStatus Status { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public DateTime? RespondedAt { get; set; }
        // Relationships
        public int RideId { get; set; }
        public Ride Ride { get; set; } = null!;
        public int DriverProfileId { get; set; }
        public DriverProfile Driver { get; set; } = null!;
        public int AssignmentId { get; set; }
        public RideAssignment Assignment { get; set; } = null!;
        /*------------------Audit-------------------*/
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
