using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsConditionObjectResponseBodyType>))]
public enum FormsConditionObjectResponseBodyType
{
    [EnumMember(Value = "multipleChoiceValueCondition")]
    MultipleChoiceValueCondition,

    [EnumMember(Value = "checkBoxesValueCondition")]
    CheckBoxesValueCondition,
}
