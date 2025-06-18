using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsFieldDefinitionObjectResponseBodyType>))]
public enum FormsFieldDefinitionObjectResponseBodyType
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

    [EnumMember(Value = "asset")]
    Asset,

    [EnumMember(Value = "person")]
    Person,

    [EnumMember(Value = "geofence")]
    Geofence,

    [EnumMember(Value = "instruction")]
    Instruction,

    [EnumMember(Value = "media_instruction")]
    MediaInstruction,

    [EnumMember(Value = "table")]
    Table,
}
