using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public class DriverProfile
    {
        public int Id { get; set; }
        public string LicenseNumber { get; set; } = null!;
        public bool IsVerified { get; set; }

        public decimal Rating { get; set; }
        public int TotalRides { get; set; }

        public DriverStatus Status { get; set; }

        public DateTime? LastOnlineAt { get; set; }
        /*-----------Navigation Properties---------------------------*/
        public ApplicationUser User { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public ICollection<Vehicle> Vehicles { get; set; }
            = new List<Vehicle>();
        public ICollection<RideAssignment> RideAssignments { get; set; }
            = new List<RideAssignment>();
        public ICollection<RideOffer> RideOffers { get; set; }
            = new List<RideOffer>();
    }

}
}
