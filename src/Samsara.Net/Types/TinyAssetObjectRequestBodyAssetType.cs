using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<TinyAssetObjectRequestBodyAssetType>))]
public enum TinyAssetObjectRequestBodyAssetType
{
    [EnumMember(Value = "uncategorized")]
    Uncategorized,

    [EnumMember(Value = "trailer")]
    Trailer,

    [EnumMember(Value = "equipment")]
    Equipment,

    [EnumMember(Value = "unpowered")]
    Unpowered,

    [EnumMember(Value = "vehicle")]
    Vehicle,
}
