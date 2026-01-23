using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Driver Efficiency score data. This object is returned by default or when the “score” format is specified in “dataFormats”.
/// </summary>
[Serializable]
public record DriverEfficiencyDataObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Represents the anticipation score for the driver. The score will be in either number or letter format depending on the organisation config.
    /// </summary>
    [JsonPropertyName("anticipationScore")]
    public string? AnticipationScore { get; set; }

    /// <summary>
    /// Represents the coasting score for the driver. The score will be in either number or letter format depending on the organisation config.
    /// </summary>
    [JsonPropertyName("coastingScore")]
    public string? CoastingScore { get; set; }

    /// <summary>
    /// Represents the cruise control score for the driver. The score will be in either number or letter format depending on the organisation config.
    /// </summary>
    [JsonPropertyName("cruiseControlScore")]
    public string? CruiseControlScore { get; set; }

    /// <summary>
    /// Represents the green band score for the driver. The score will be in either number or letter format depending on the organisation config.
    /// </summary>
    [JsonPropertyName("greenBandScore")]
    public string? GreenBandScore { get; set; }

    /// <summary>
    /// Represents the high torque score for the driver. The score will be in either number or letter format depending on the organisation config.
    /// </summary>
    [JsonPropertyName("highTorqueScore")]
    public string? HighTorqueScore { get; set; }

    /// <summary>
    /// Represents the idling score for the driver.The score will be in either number or letter format depending on the organisation config.
    /// </summary>
    [JsonPropertyName("idlingScore")]
    public string? IdlingScore { get; set; }

    /// <summary>
    /// Represents the over speed score for the driver. The score will be in either number or letter format depending on the organisation config.
    /// </summary>
    [JsonPropertyName("overSpeedScore")]
    public string? OverSpeedScore { get; set; }

    /// <summary>
    /// Represents the overall score for the driver. The score will be in either number (0-100) as a string or letter format (A-G) depending on the organisation config.
    /// </summary>
    [JsonPropertyName("overallScore")]
    public required string OverallScore { get; set; }

    /// <summary>
    /// Represents the ware-free breaking score for the driver. The score will be in either number or letter format depending on the organisation config.
    /// </summary>
    [JsonPropertyName("wearFreeBrakeScore")]
    public string? WearFreeBrakeScore { get; set; }

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
