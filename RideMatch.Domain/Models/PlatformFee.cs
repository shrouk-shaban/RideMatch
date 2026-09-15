using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public class PlatformFee
    {
        public int Id { get; set; }
        public decimal ?BaseFare { get; set; }
        public decimal PricePerKm { get; set; }
        public decimal PricePerMinute { get; set; }
        public decimal PlatformCommissionPercentage { get; set; }
        public string UpdatedByUserId { get; set; } = null!;
        // Relationship
        public ApplicationUser UpdatedByUser { get; set; } = null!;
        /*------------------Audit-------------------*/
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
