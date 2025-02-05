using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta;

[JsonConverter(typeof(EnumSerializer<BetaGetTripsRequestCompletionStatus>))]
public enum BetaGetTripsRequestCompletionStatus
{
    [EnumMember(Value = "inProgress")]
    InProgress,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "all")]
    All,
}
