using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.LiveShares;

[JsonConverter(typeof(EnumSerializer<LiveSharesListRequestType>))]
public enum LiveSharesListRequestType
{
    [EnumMember(Value = "all")]
    All,

    [EnumMember(Value = "assetsLocation")]
    AssetsLocation,

    [EnumMember(Value = "assetsNearLocation")]
    AssetsNearLocation,

    [EnumMember(Value = "assetsOnRoute")]
    AssetsOnRoute,
}
