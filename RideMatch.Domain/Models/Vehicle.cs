using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string? Make { get; set; } 
        public string? Model { get; set; } 
        public int? Year { get; set; }
        public string? Color { get; set; } 
        public string PlateNumber { get; set; } = null!;
        public string? VehicleType { get; set; }
        public bool IsActive { get; set; }

        /*-----------Navigation Properties---------------------------*/
        public int DriverProfileId { get; set; }
        public DriverProfile Driver { get; set; } = null!;
    }
}
