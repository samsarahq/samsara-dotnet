using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<V1VisionStepResultsItemCaliperFilterPolarity>))]
public enum V1VisionStepResultsItemCaliperFilterPolarity
{
    [EnumMember(Value = "LIGHT TO DARK")]
    LightToDark,

    [EnumMember(Value = "DARK TO LIGHT")]
    DarkToLight,
}
