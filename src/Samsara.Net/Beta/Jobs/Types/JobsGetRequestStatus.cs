using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta.Jobs;

[JsonConverter(typeof(EnumSerializer<JobsGetRequestStatus>))]
public enum JobsGetRequestStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "scheduled")]
    Scheduled,

    [EnumMember(Value = "completed")]
    Completed,
}
