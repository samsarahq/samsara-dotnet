using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta;

[JsonConverter(typeof(EnumSerializer<BetaGetTripsRequestQueryBy>))]
public enum BetaGetTripsRequestQueryBy
{
    [EnumMember(Value = "updatedAtTime")]
    UpdatedAtTime,

    [EnumMember(Value = "tripStartTime")]
    TripStartTime,
}
