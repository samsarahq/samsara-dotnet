using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The gross weight of the vehicle in either pounds (lb) or kilograms (kg). Only returned for customers with commercial speed limits (CSL) enabled.
/// </summary>
public record GrossVehicleWeight
{
    /// <summary>
    /// The unit of weight for the vehicle.
    /// </summary>
    [JsonPropertyName("unit")]
    public GrossVehicleWeightUnit? Unit { get; set; }

    /// <summary>
    /// The weight value of the vehicle.
    /// </summary>
    [JsonPropertyName("weight")]
    public long? Weight { get; set; }

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
