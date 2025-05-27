using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<WorkOrderObjectResponseBodyPriority>))]
public enum WorkOrderObjectResponseBodyPriority
{
    [EnumMember(Value = "High")]
    High,

    [EnumMember(Value = "Low")]
    Low,

    [EnumMember(Value = "Medium")]
    Medium,

    [EnumMember(Value = "Urgent")]
    Urgent,
}
