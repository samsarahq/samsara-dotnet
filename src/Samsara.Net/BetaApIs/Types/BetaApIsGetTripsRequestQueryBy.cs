using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(EnumSerializer<BetaApIsGetTripsRequestQueryBy>))]
public enum BetaApIsGetTripsRequestQueryBy
{
    [EnumMember(Value = "updatedAtTime")]
    UpdatedAtTime,

    [EnumMember(Value = "tripStartTime")]
    TripStartTime,
}
