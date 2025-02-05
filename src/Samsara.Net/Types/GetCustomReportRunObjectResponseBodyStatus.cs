using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<GetCustomReportRunObjectResponseBodyStatus>))]
public enum GetCustomReportRunObjectResponseBodyStatus
{
    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "failed")]
    Failed,

    [EnumMember(Value = "cancelled")]
    Cancelled,
}
