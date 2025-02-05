using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsDateTimeValueObjectResponseBodyType>))]
public enum FormsDateTimeValueObjectResponseBodyType
{
    [EnumMember(Value = "datetime")]
    Datetime,

    [EnumMember(Value = "date")]
    Date,

    [EnumMember(Value = "time")]
    Time,
}
