using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Trips;

[JsonConverter(typeof(EnumSerializer<TripsStreamRequestCompletionStatus>))]
public enum TripsStreamRequestCompletionStatus
{
    [EnumMember(Value = "inProgress")]
    InProgress,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "all")]
    All,
}
