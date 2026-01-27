using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The threshold value of the alert for continuous readings.
/// </summary>
[Serializable]
public record ContinuousReadingAlertThresholdResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The operation used when comparing the value to the threshold.  Valid values: `GREATER`, `INSIDE_RANGE`, `LESS`, `OUTSIDE_RANGE`
    /// </summary>
    [JsonPropertyName("operation")]
    public required ContinuousReadingAlertThresholdResponseBodyOperation Operation { get; set; }

    /// <summary>
    /// The lower threshold of criticality.
    /// </summary>
    [JsonPropertyName("threshold")]
    public required long Threshold { get; set; }

    /// <summary>
    /// The unit of the threshold defined by reading type.  Valid values: `ampere`, `bar`, `cad`, `celsius`, `chf`, `day`, `decimaldegrees`, `eur`, `fahrenheit`, `foot`, `gallon`, `gallonperkilogram`, `gallonsperhour`, `galpermi`, `gbp`, `gforce`, `gperliter`, `gperm`, `hertz`, `hour`, `imperialgallonperkilogram`, `impgallon`, `impgallonsperhour`, `impgalpermi`, `inch`, `kelvin`, `kgper100kmgaseousfuel`, `kgpergallon`, `kgperkm`, `kgperliter`, `kgpermi`, `kilogram`, `kilogramgaseousfuel`, `kilometer`, `kilopascal`, `kilowatthour`, `kmperhr`, `kmperl`, `kmperlgaseousfuel`, `lbpermi`, `liter`, `litergaseousfuel`, `literperkilogram`, `literpertonne`, `litersperhour`, `lper100km`, `lper100kmgaseousfuel`, `lperkm`, `lperm`, `meter`, `meterspersec`, `mile`, `milliknot`, `millisecond`, `millivolt`, `minute`, `mipergal`, `miperhr`, `miperimpgal`, `month`, `mpgusgalgaseousfuel`, `mpkggaseousfuel`, `mxn`, `percent`, `pound`, `poundsPerSquareInch`, `poundspergallon`, `poundsperliter`, `rpm`, `second`, `usd`, `usgallongaseousfuel`, `volt`, `voltAmpere`, `voltAmpereReactive`, `watt`, `watthour`, `week`
    /// </summary>
    [JsonPropertyName("unit")]
    public ContinuousReadingAlertThresholdResponseBodyUnit? Unit { get; set; }

    /// <summary>
    /// The upper threshold of criticality. Required for RANGE operations.
    /// </summary>
    [JsonPropertyName("upperThreshold")]
    public long? UpperThreshold { get; set; }

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
