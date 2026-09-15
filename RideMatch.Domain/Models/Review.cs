using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public class Review
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        // Relationships
        public int RideId { get; set; }
        public Ride Ride { get; set; } = null!;
        public string ReviewerId { get; set; } = null!;
        public string RevieweeId { get; set; } = null!;
        public ApplicationUser Reviewer { get; set; } = null!;
        public ApplicationUser Reviewee { get; set; } = null!;
    }
}
