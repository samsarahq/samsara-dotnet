using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<AttributeAttributeType>))]
public enum AttributeAttributeType
{
    [EnumMember(Value = "string")]
    String,

    [EnumMember(Value = "number")]
    Number,
}
