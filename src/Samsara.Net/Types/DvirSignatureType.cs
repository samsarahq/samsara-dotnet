using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<DvirSignatureType>))]
public enum DvirSignatureType
{
    [EnumMember(Value = "driver")]
    Driver,

    [EnumMember(Value = "mechanic")]
    Mechanic,
}
