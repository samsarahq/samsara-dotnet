using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// An enrolled vehicle with its latest CARB CTC compliance status.
/// </summary>
[Serializable]
public record CarbCtcVehicleObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique identifier for this CARB CTC enrollment.
    /// </summary>
    [JsonPropertyName("enrollmentId")]
    public required string EnrollmentId { get; set; }

    /// <summary>
    /// Vehicle Identification Number associated with the CARB CTC enrollment.
    /// </summary>
    [JsonPropertyName("enrollmentVin")]
    public required string EnrollmentVin { get; set; }

    /// <summary>
    /// Samsara vehicle ID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// When the most recent data collection happened, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("lastCollectionAtTime")]
    public DateTime? LastCollectionAtTime { get; set; }

    /// <summary>
    /// When the next data collection is scheduled, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("nextCollectionAtTime")]
    public DateTime? NextCollectionAtTime { get; set; }

    /// <summary>
    /// Current CARB CTC compliance test status.  Valid values: `notScheduled`, `scheduled`, `inProgress`, `awaitingResult`, `pass`, `fail`, `error`, `unknown`
    /// </summary>
    [JsonPropertyName("testStatus")]
    public required CarbCtcVehicleObjectResponseBodyTestStatus TestStatus { get; set; }

    /// <summary>
    /// Human-readable context for the test status.
    /// </summary>
    [JsonPropertyName("testStatusDetails")]
    public string? TestStatusDetails { get; set; }

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
