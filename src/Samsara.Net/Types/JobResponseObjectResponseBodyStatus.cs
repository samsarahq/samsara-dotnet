using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<JobResponseObjectResponseBodyStatus>))]
public enum JobResponseObjectResponseBodyStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "scheduled")]
    Scheduled,

    [EnumMember(Value = "completed")]
    Completed,
}
