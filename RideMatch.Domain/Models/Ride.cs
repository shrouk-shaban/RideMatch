using RideMatch.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public class Ride
    {
        public int Id { get; set; }
        public Location PickupLocation { get; set; } = null!;
        public Location DestinationLocation { get; set; } = null!;
        public decimal EstimatedDistanceKm { get; set; }
        public int EstimatedDurationMin { get; set; }
        public decimal EstimatedFare { get; set; }
        public decimal? AgreedFare { get; set; }
        public RideStatus Status { get; set; }
        public DateTime RequestedAt { get; set; }
        public DateTime? AcceptedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? CompletedAt { get; set; }

        // Relationships
        public ApplicationUser Rider { get; set; } = null!;
        public string RiderId { get; set; } = null!;
        public DriverProfile? Driver { get; set; }
        public int? DriverProfileId { get; set; }
        public ICollection<RideAssignment> RideAssignments { get; set; }
            = new List<RideAssignment>();

      /*  public ICollection<RideOffer> RideOffers { get; set; }
            = new List<RideOffer>();

        public ICollection<RideStatusHistory> StatusHistory { get; set; }
            = new List<RideStatusHistory>();

        public ICollection<Payment> Payments { get; set; }
            = new List<Payment>();

        public ICollection<Review> Reviews { get; set; }
            = new List<Review>();*/

    }
}
