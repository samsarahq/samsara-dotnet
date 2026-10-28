using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record MaintenanceEstimatesListMaintenanceEstimatesResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Matching estimate records.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<MaintenanceEstimateObjectResponseBody> Data { get; set; } =
        new List<MaintenanceEstimateObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required MaintenanceEstimatesPaginationResponseBody Pagination { get; set; }

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
