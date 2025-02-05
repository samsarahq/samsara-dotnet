using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(EnumSerializer<AssetsCreateAssetRequestBodyRegulationMode>))]
public enum AssetsCreateAssetRequestBodyRegulationMode
{
    [EnumMember(Value = "mixed")]
    Mixed,

    [EnumMember(Value = "regulated")]
    Regulated,

    [EnumMember(Value = "unregulated")]
    Unregulated,
}
