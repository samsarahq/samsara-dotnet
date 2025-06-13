using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormSubmissionRequestFieldInputObjectRequestBodyType>))]
public enum FormSubmissionRequestFieldInputObjectRequestBodyType
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

    [EnumMember(Value = "asset")]
    Asset,

    [EnumMember(Value = "person")]
    Person,

    [EnumMember(Value = "table")]
    Table,
}
