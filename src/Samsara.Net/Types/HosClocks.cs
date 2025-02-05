using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record HosClocks
{
    [JsonPropertyName("break")]
    public HosBreak? Break { get; set; }

    [JsonPropertyName("cycle")]
    public HosCycle? Cycle { get; set; }

    [JsonPropertyName("drive")]
    public HosDrive? Drive { get; set; }

    [JsonPropertyName("shift")]
    public HosShift? Shift { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
