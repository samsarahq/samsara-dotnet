using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<AssetResponseBodyRegulationMode>))]
public enum AssetResponseBodyRegulationMode
{
    [EnumMember(Value = "mixed")]
    Mixed,

    [EnumMember(Value = "regulated")]
    Regulated,

    [EnumMember(Value = "unregulated")]
    Unregulated,
}
