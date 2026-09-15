using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public class Notifications 
    {
        public int Id { get; set; }
        public string Type { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Message { get; set; } = null!;
        public string? Payload { get; set; }
        public bool IsRead { get; set; }
        public DateTime? ReadAt { get; set; }

        // Relationship
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;
       
    }
}
