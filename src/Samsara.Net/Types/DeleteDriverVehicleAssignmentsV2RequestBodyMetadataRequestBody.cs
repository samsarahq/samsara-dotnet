using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Metadata identifying the driver assignments to delete
/// </summary>
[Serializable]
public record DeleteDriverVehicleAssignmentsV2RequestBodyMetadataRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Exact metadata source name. When provided without vehicleId, deletes the single API-created assignment with this source name; startTime, endTime, and isPassenger must then be omitted. Returns an error if no assignment or more than one assignment matches. If vehicleId is provided, sourceName is ignored and assignments are deleted by vehicle and time range. Required unless vehicleId is provided.
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
