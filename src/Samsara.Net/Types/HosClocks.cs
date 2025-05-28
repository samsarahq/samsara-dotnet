using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Remaining durations and start times (where applicable) for various HOS rules. See [this page](https://www.samsara.com/fleet/eld-compliance/hours-of-service) for more information on HOS rules.
/// </summary>
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
