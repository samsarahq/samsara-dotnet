using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The cumulative idling duration in milliseconds. Cumulative values always increase. For filtering of idling duration please use <a href="/api-reference/fuel-and-efficiency/idling/get-idling-events" target="_blank">the Idling Events API</a>.
/// </summary>
[Serializable]
public record VehicleStatsIdlingDurationMilliseconds : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("time")]
    public required string Time { get; set; }

    /// <summary>
    /// The cumulative idling duration in milliseconds. Cumulative values always increase. For filtering of idling duration please use <a href="/api-reference/fuel-and-efficiency/idling/get-idling-events" target="_blank">the Idling Events API</a>.
    /// </summary>
    [JsonPropertyName("value")]
    public required long Value { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
