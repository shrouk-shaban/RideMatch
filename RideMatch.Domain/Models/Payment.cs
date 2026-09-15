using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public class Payment
    {
        public int Id { get; set; }
        public int RideId { get; set; }
        public decimal Amount { get; set; }
        public decimal PlatformFeeAmount { get; set; }
        public decimal DriverAmount { get; set; }

        // Snapshot of the percentage used for this payment
        public decimal PlatformCommissionPercentage { get; set; }
        public PaymentStatus Status { get; set; }
        public string? TransactionReference { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? PaidAt { get; set; }

        // Relationship
        public Ride Ride { get; set; } = null!;
    }
}
