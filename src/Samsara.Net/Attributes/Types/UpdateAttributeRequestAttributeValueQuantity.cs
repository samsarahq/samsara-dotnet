using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(EnumSerializer<UpdateAttributeRequestAttributeValueQuantity>))]
public enum UpdateAttributeRequestAttributeValueQuantity
{
    [EnumMember(Value = "single")]
    Single,

    [EnumMember(Value = "multi")]
    Multi,
}
