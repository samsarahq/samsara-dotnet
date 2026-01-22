using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1VisionStepResultsItemPresenceAbsence : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("blueRange")]
    public V1VisionStepResultsItemPresenceAbsenceBlueRange? BlueRange { get; set; }

    [JsonPropertyName("checkForAbsence")]
    public bool? CheckForAbsence { get; set; }

    [JsonPropertyName("grayscaleRange")]
    public V1VisionStepResultsItemPresenceAbsenceGrayscaleRange? GrayscaleRange { get; set; }

    [JsonPropertyName("greenRange")]
    public V1VisionStepResultsItemPresenceAbsenceGreenRange? GreenRange { get; set; }

    [JsonPropertyName("hueRange")]
    public V1VisionStepResultsItemPresenceAbsenceHueRange? HueRange { get; set; }

    [JsonPropertyName("redRange")]
    public V1VisionStepResultsItemPresenceAbsenceRedRange? RedRange { get; set; }

    [JsonPropertyName("saturationRange")]
    public V1VisionStepResultsItemPresenceAbsenceSaturationRange? SaturationRange { get; set; }

    [JsonPropertyName("score")]
    public long? Score { get; set; }

    [JsonPropertyName("threshold")]
    public long? Threshold { get; set; }

    [JsonPropertyName("valueRange")]
    public V1VisionStepResultsItemPresenceAbsenceValueRange? ValueRange { get; set; }

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
