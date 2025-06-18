using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Threshold to alert on if reading is continuous, either enum or continuous threshold may be set.
/// </summary>
public record ReadingTriggerContinuousValueObjectResponseBody
{
    /// <summary>
    /// The operation to use when comparing the value to the threshold.  Valid values: `GREATER`, `INSIDE_RANGE`, `LESS`, `OUTSIDE_RANGE`
    /// </summary>
    [JsonPropertyName("operation")]
    public required ReadingTriggerContinuousValueObjectResponseBodyOperation Operation { get; set; }

    /// <summary>
    /// The lower threshold of criticality.
    /// </summary>
    [JsonPropertyName("threshold")]
    public required long Threshold { get; set; }

    /// <summary>
    /// The unit of the threshold defined by reading type. If not provided base unit of the reading will be used.  Valid values: `bar`, `celsius`, `fahrenheit`, `foot`, `gallon`, `galpermi`, `gforce`, `gperliter`, `gperm`, `hour`, `impgallon`, `impgalpermi`, `inch`, `kelvin`, `kgper100kmgaseousfuel`, `kgpergallon`, `kgperkm`, `kgperliter`, `kgpermi`, `kilogram`, `kilogramgaseousfuel`, `kilometer`, `kilopascal`, `kilowatthour`, `kmperhr`, `lbpermi`, `liter`, `litergaseousfuel`, `lper100km`, `lper100kmgaseousfuel`, `lperkm`, `lperm`, `meter`, `meterspersec`, `mile`, `milliknot`, `millisecond`, `millivolt`, `mipergal`, `miperhr`, `miperimpgal`, `mpgusgalgaseousfuel`, `mpkggaseousfuel`, `percent`, `pound`, `poundsPerSquareInch`, `poundspergallon`, `poundsperliter`, `second`, `usd`, `usgallongaseousfuel`, `volt`, `watthour`
    /// </summary>
    [JsonPropertyName("unit")]
    public ReadingTriggerContinuousValueObjectResponseBodyUnit? Unit { get; set; }

    /// <summary>
    /// The upper threshold of criticality. Required for RANGE operations.
    /// </summary>
    [JsonPropertyName("upperThreshold")]
    public long? UpperThreshold { get; set; }

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
