using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Metadata about this driver assignment
/// </summary>
[Serializable]
public record PatchDriverVehicleAssignmentsV2RequestBodyMetadataRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Exact metadata source name. When vehicleId, driverId, and startTime are omitted, identifies the existing assignment to update. When those identity fields are provided, sets or updates the assignment's source name.
    /// </summary>
    [JsonPropertyName("sourceName")]
    public string? SourceName { get; set; }

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
