using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType>)
)]
public enum FormsTableFieldDefinitionObjectResponseBodyAllowedDateTimeValueType
{
    [EnumMember(Value = "datetime")]
    Datetime,

    [EnumMember(Value = "date")]
    Date,

    [EnumMember(Value = "time")]
    Time,
}
