using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(EnumSerializer<CreateAttributeRequestAttributeType>))]
public enum CreateAttributeRequestAttributeType
{
    [EnumMember(Value = "string")]
    String,

    [EnumMember(Value = "number")]
    Number,
}
