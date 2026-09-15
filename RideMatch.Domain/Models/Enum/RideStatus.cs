using System;
using System.Collections.Generic;
using System.Text;

namespace RideMatch.Domain
{
    public enum RideStatus
    {
        Requested,
    Matching,
    Accepted,
    DriverArriving,
    DriverArrived,
    InProgress,
    Completed,
    Cancelled,
    Expired
    }
}
