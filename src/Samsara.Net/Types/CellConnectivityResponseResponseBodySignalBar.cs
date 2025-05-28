using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<CellConnectivityResponseResponseBodySignalBar>))]
public enum CellConnectivityResponseResponseBodySignalBar
{
    [EnumMember(Value = "1/4")]
    One4,

    [EnumMember(Value = "2/4")]
    Two4,

    [EnumMember(Value = "3/4")]
    Three4,

    [EnumMember(Value = "4/4")]
    Four4,

    [EnumMember(Value = "unknown")]
    Unknown,
}
