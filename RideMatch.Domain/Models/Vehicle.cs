using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Year { get; set; }
        public string Color { get; set; } = null!;
        public string PlateNumber { get; set; } = null!;
        public string VehicleType { get; set; } = null!;
        public bool IsActive { get; set; }

        /*-----------Navigation Properties---------------------------*/
        public int DriverProfileId { get; set; }
        public DriverProfile Driver { get; set; } = null!;
    }
}
