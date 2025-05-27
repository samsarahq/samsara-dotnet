using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<ServiceTaskInstanceObjectResponseBodyStatus>))]
public enum ServiceTaskInstanceObjectResponseBodyStatus
{
    [EnumMember(Value = "Unknown")]
    Unknown,

    [EnumMember(Value = "Open")]
    Open,

    [EnumMember(Value = "In Progress")]
    InProgress,

    [EnumMember(Value = "On Hold")]
    OnHold,

    [EnumMember(Value = "Completed")]
    Completed,
}
