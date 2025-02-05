using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Attributes;

[JsonConverter(typeof(EnumSerializer<CreateAttributeRequestEntityType>))]
public enum CreateAttributeRequestEntityType
{
    [EnumMember(Value = "driver")]
    Driver,

    [EnumMember(Value = "asset")]
    Asset,
}
