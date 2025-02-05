using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<WorkflowDvirObjectResponseBodySafetyStatus>))]
public enum WorkflowDvirObjectResponseBodySafetyStatus
{
    [EnumMember(Value = "safe")]
    Safe,

    [EnumMember(Value = "unsafe")]
    Unsafe,

    [EnumMember(Value = "resolved")]
    Resolved,
}
