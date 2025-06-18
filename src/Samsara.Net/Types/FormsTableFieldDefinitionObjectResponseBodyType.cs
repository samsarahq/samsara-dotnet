using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsTableFieldDefinitionObjectResponseBodyType>))]
public enum FormsTableFieldDefinitionObjectResponseBodyType
{
    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "text")]
    Text,

    [EnumMember(Value = "multiple_choice")]
    MultipleChoice,

    [EnumMember(Value = "check_boxes")]
    CheckBoxes,

    [EnumMember(Value = "media")]
    Media,

    [EnumMember(Value = "datetime")]
    Datetime,

    [EnumMember(Value = "signature")]
    Signature,

    [EnumMember(Value = "person")]
    Person,
}
