using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A collection history entry for a vehicle enrolled in the CARB CTC program.
/// </summary>
[Serializable]
public record CarbCtcVehicleHistoryObjectResponseBody : IJsonOnDeserialized
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
    /// When the collection happened, in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public required DateTime HappenedAtTime { get; set; }

    /// <summary>
    /// Samsara vehicle ID.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The outcome of the collection test.  Valid values: `pass`, `fail`, `error`, `unknown`
    /// </summary>
    [JsonPropertyName("testResult")]
    public required CarbCtcVehicleHistoryObjectResponseBodyTestResult TestResult { get; set; }

    /// <summary>
    /// Human-readable context for the test result.
    /// </summary>
    [JsonPropertyName("testResultDetails")]
    public string? TestResultDetails { get; set; }

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
