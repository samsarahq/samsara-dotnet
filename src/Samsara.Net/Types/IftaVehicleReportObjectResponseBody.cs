using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record IftaVehicleReportObjectResponseBody
{
    /// <summary>
    /// List of jurisdiction summaries.
    /// </summary>
    [JsonPropertyName("jurisdictions")]
    public IEnumerable<IftaJurisdictionSummaryObjectResponseBody> Jurisdictions { get; set; } =
        new List<IftaJurisdictionSummaryObjectResponseBody>();

    [JsonPropertyName("vehicle")]
    public required GoaVehicleTinyResponseResponseBody Vehicle { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
