using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Gateway cellular connectivity information.
/// </summary>
public record CellConnectivityResponseResponseBody
{
    /// <summary>
    /// The cellular network provider name.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>
    /// The cellular signal strength indicator.  Valid values: `1/4`, `2/4`, `3/4`, `4/4`, `unknown`
    /// </summary>
    [JsonPropertyName("signalBar")]
    public CellConnectivityResponseResponseBodySignalBar? SignalBar { get; set; }

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
