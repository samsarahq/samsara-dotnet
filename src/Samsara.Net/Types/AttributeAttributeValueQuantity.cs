using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<AttributeAttributeValueQuantity>))]
public enum AttributeAttributeValueQuantity
{
    [EnumMember(Value = "single")]
    Single,

    [EnumMember(Value = "multi")]
    Multi,
}
