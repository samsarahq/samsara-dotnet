using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(EnumSerializer<CreateAttributeRequestAttributeValueQuantity>))]
public enum CreateAttributeRequestAttributeValueQuantity
{
    [EnumMember(Value = "single")]
    Single,

    [EnumMember(Value = "multi")]
    Multi,
}
