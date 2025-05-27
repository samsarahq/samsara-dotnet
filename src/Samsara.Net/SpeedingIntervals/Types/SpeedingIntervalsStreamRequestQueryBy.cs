using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.SpeedingIntervals;

[JsonConverter(typeof(EnumSerializer<SpeedingIntervalsStreamRequestQueryBy>))]
public enum SpeedingIntervalsStreamRequestQueryBy
{
    [EnumMember(Value = "updatedAtTime")]
    UpdatedAtTime,

    [EnumMember(Value = "tripStartTime")]
    TripStartTime,
}
