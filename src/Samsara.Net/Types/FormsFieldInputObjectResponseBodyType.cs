using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsFieldInputObjectResponseBodyType>))]
public enum FormsFieldInputObjectResponseBodyType
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

    [EnumMember(Value = "asset")]
    Asset,

    [EnumMember(Value = "table")]
    Table,

    [EnumMember(Value = "person")]
    Person,

    [EnumMember(Value = "geofence")]
    Geofence,
}
