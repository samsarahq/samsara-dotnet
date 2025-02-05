using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(EnumSerializer<BetaApIsGetJobsRequestStatus>))]
public enum BetaApIsGetJobsRequestStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "scheduled")]
    Scheduled,

    [EnumMember(Value = "completed")]
    Completed,
}
