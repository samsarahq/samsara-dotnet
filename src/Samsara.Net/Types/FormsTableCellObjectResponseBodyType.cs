using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsTableCellObjectResponseBodyType>))]
public enum FormsTableCellObjectResponseBodyType
{
    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "text")]
    Text,

    [EnumMember(Value = "multiple_choice")]
    MultipleChoice,

    [EnumMember(Value = "check_boxes")]
    CheckBoxes,

    [EnumMember(Value = "datetime")]
    Datetime,

    [EnumMember(Value = "signature")]
    Signature,

    [EnumMember(Value = "media")]
    Media,

    [EnumMember(Value = "person")]
    Person,
}
