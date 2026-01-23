using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record IdlingReportsGetVehicleIdlingReportsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Multiple idling events.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<IdlingReportEventResponseBody> Data { get; set; } =
        new List<IdlingReportEventResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

    /// <summary>
    /// The requested end time in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("requestEndTime")]
    public required string RequestEndTime { get; set; }

    /// <summary>
    /// The requested start time in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("requestStartTime")]
    public required string RequestStartTime { get; set; }

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
