using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsTableColumnObjectResponseBodyType>))]
public enum FormsTableColumnObjectResponseBodyType
{
    [EnumMember(Value = "text")]
    Text,

    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "datetime")]
    Datetime,

    [EnumMember(Value = "check_boxes")]
    CheckBoxes,

    [EnumMember(Value = "multiple_choice")]
    MultipleChoice,

    [EnumMember(Value = "signature")]
    Signature,

    [EnumMember(Value = "media")]
    Media,

    [EnumMember(Value = "person")]
    Person,
}
