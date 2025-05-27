using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Trips;

[JsonConverter(typeof(EnumSerializer<TripsStreamRequestQueryBy>))]
public enum TripsStreamRequestQueryBy
{
    [EnumMember(Value = "updatedAtTime")]
    UpdatedAtTime,

    [EnumMember(Value = "tripStartTime")]
    TripStartTime,
}
