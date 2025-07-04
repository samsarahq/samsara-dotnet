using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Assets;

[JsonConverter(typeof(EnumSerializer<AssetsUpdateAssetRequestBodyRegulationMode>))]
public enum AssetsUpdateAssetRequestBodyRegulationMode
{
    [EnumMember(Value = "mixed")]
    Mixed,

    [EnumMember(Value = "regulated")]
    Regulated,

    [EnumMember(Value = "unregulated")]
    Unregulated,
}
