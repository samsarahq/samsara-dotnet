using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<CustomReportColumnsObjectResponseBodyType>))]
public enum CustomReportColumnsObjectResponseBodyType
{
    [EnumMember(Value = "string")]
    String,

    [EnumMember(Value = "numeric")]
    Numeric,
}
