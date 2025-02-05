using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta;

[JsonConverter(typeof(EnumSerializer<IssuesPatchIssueRequestBodyStatus>))]
public enum IssuesPatchIssueRequestBodyStatus
{
    [EnumMember(Value = "open")]
    Open,

    [EnumMember(Value = "inProgress")]
    InProgress,

    [EnumMember(Value = "resolved")]
    Resolved,

    [EnumMember(Value = "dismissed")]
    Dismissed,
}
