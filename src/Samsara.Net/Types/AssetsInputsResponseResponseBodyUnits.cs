using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<AssetsInputsResponseResponseBodyUnits>))]
public enum AssetsInputsResponseResponseBodyUnits
{
    [EnumMember(Value = "boolean")]
    Boolean,

    [EnumMember(Value = "millivolts")]
    Millivolts,

    [EnumMember(Value = "microamps")]
    Microamps,
}
