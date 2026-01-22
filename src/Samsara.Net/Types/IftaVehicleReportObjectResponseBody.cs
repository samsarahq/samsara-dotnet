using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A summary of this vehicle's IFTA data.
/// </summary>
[Serializable]
public record IftaVehicleReportObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// List of jurisdiction summaries.
    /// </summary>
    [JsonPropertyName("jurisdictions")]
    public IEnumerable<IftaJurisdictionSummaryObjectResponseBody> Jurisdictions { get; set; } =
        new List<IftaJurisdictionSummaryObjectResponseBody>();

    [JsonPropertyName("vehicle")]
    public required GoaVehicleTinyResponseResponseBody Vehicle { get; set; }

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
