using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.V1.Sensors;

[JsonConverter(typeof(EnumSerializer<InlineObject6FillMissing>))]
public enum InlineObject6FillMissing
{
    [EnumMember(Value = "withNull")]
    WithNull,

    [EnumMember(Value = "withPrevious")]
    WithPrevious,
}
