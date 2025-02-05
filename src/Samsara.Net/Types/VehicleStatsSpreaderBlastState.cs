using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record VehicleStatsSpreaderBlastState
{
    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// Whether vehicle is actively spreading material in ‘blast mode’.
    /// </summary>
    [JsonPropertyName("value")]
    public required VehicleStatsSpreaderBlastStateValue Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
