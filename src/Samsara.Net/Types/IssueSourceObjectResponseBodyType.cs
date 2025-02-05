using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<IssueSourceObjectResponseBodyType>))]
public enum IssueSourceObjectResponseBodyType
{
    [EnumMember(Value = "form")]
    Form,

    [EnumMember(Value = "ad-hoc")]
    AdHoc,
}
