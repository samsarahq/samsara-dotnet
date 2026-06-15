using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record EntityUpcomingPreventativeMaintenancesServiceListUpcomingPreventiveMaintenanceResponseBody
    : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// An array of UpcomingPreventativeMaintenances
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<EntityListUpcomingPreventiveMaintenanceTypeResponseBody> Data { get; set; } =
        new List<EntityListUpcomingPreventiveMaintenanceTypeResponseBody>();

    [JsonPropertyName("pagination")]
    public required GoaPaginationResponseResponseBody Pagination { get; set; }

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
