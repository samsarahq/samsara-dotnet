using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<AssetsUpdateAssetResponseBodyRegulationMode>))]
public enum AssetsUpdateAssetResponseBodyRegulationMode
{
    [EnumMember(Value = "mixed")]
    Mixed,

    [EnumMember(Value = "regulated")]
    Regulated,

    [EnumMember(Value = "unregulated")]
    Unregulated,
}
