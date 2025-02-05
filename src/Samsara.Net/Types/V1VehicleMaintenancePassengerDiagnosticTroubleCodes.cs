using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VehicleMaintenancePassengerDiagnosticTroubleCodes
{
    [JsonPropertyName("dtcDescription")]
    public required string DtcDescription { get; set; }

    [JsonPropertyName("dtcId")]
    public required int DtcId { get; set; }

    [JsonPropertyName("dtcShortCode")]
    public required string DtcShortCode { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
