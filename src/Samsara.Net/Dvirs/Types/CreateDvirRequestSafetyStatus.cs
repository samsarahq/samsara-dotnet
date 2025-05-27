using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Dvirs;

[JsonConverter(typeof(EnumSerializer<CreateDvirRequestSafetyStatus>))]
public enum CreateDvirRequestSafetyStatus
{
    [EnumMember(Value = "safe")]
    Safe,

    [EnumMember(Value = "unsafe")]
    Unsafe,
}
