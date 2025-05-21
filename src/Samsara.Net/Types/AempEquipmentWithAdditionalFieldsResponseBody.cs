using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Contains equipment fields.
/// </summary>
public record AempEquipmentWithAdditionalFieldsResponseBody
{
    [JsonPropertyName("CumulativeOperatingHours")]
    public CumulativeOperatingHoursResponseBody? CumulativeOperatingHours { get; set; }

    [JsonPropertyName("DEFRemaining")]
    public DefRemainingResponseBody? DefRemaining { get; set; }

    [JsonPropertyName("Distance")]
    public DistanceResponseBody? Distance { get; set; }

    [JsonPropertyName("EngineStatus")]
    public EngineStatusResponseBody? EngineStatus { get; set; }

    [JsonPropertyName("EquipmentHeader")]
    public required EquipmentHeaderWithAdditionalFieldsResponseBody EquipmentHeader { get; set; }

    [JsonPropertyName("FuelRemaining")]
    public FuelRemainingResponseBody? FuelRemaining { get; set; }

    [JsonPropertyName("Location")]
    public required LocationResponseBody Location { get; set; }

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
