using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain.ValueObject
{
    public record Location
    {
        
            public decimal Latitude { get; init; }
            public decimal Longitude { get; init; }

            private Location() { }

            private Location(decimal latitude, decimal longitude)
            {
                Latitude = latitude;
                Longitude = longitude;
            }

            public static Location Create(
                decimal latitude,
                decimal longitude)
            {
                if (latitude < -90 || latitude > 90)
                    throw new ArgumentOutOfRangeException(nameof(latitude));

                if (longitude < -180 || longitude > 180)
                    throw new ArgumentOutOfRangeException(nameof(longitude));

                return new Location(latitude, longitude);
            }
        
    }
}
