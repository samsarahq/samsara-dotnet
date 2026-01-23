using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A DVIR description.
/// </summary>
[Serializable]
public record Dvir2SubmissionResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("baseFormSubmission")]
    public Dvir2FormSubmissionObjectResponseBody? BaseFormSubmission { get; set; }

    /// <summary>
    /// Inspection type of the DVIR.  Valid values: `preTrip`, `postTrip`, `mechanic`, `unset`
    /// </summary>
    [JsonPropertyName("inspectionType")]
    public required Dvir2SubmissionResponseObjectResponseBodyInspectionType InspectionType { get; set; }

    /// <summary>
    /// List of devices (vehicles/trailers) associated with the DVIR.
    /// </summary>
    [JsonPropertyName("relatedDevices")]
    public IEnumerable<Dvir2RelatedDeviceObjectResponseBody> RelatedDevices { get; set; } =
        new List<Dvir2RelatedDeviceObjectResponseBody>();

    /// <summary>
    /// The unique UUID of the DVIR2 submission
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; set; }

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
