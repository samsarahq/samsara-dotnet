using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta.Assets;

[JsonConverter(typeof(EnumSerializer<AssetsListRequestType>))]
public enum AssetsListRequestType
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
