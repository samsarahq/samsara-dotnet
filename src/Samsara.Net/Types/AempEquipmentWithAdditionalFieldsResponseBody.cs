using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
