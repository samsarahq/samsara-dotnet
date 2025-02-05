using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(EnumSerializer<BetaApIsGetTripsRequestCompletionStatus>))]
public enum BetaApIsGetTripsRequestCompletionStatus
{
    [EnumMember(Value = "inProgress")]
    InProgress,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "all")]
    All,
}
