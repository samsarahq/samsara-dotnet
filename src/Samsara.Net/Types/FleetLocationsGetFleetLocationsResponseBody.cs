using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record FleetLocationsGetFleetLocationsResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pagination")]
    public required FleetLocationsPaginationResponseBody Pagination { get; set; }

    /// <summary>
    /// List of vehicle locations.
    /// </summary>
    [JsonPropertyName("vehicles")]
    public IEnumerable<VehicleLocationResponseBody> Vehicles { get; set; } =
        new List<VehicleLocationResponseBody>();

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
