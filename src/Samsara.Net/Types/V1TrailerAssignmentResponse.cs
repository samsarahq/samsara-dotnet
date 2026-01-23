using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record V1TrailerAssignmentResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The ID of the driver associated with this trailer.
    /// </summary>
    [JsonPropertyName("driverId")]
    public long? DriverId { get; set; }

    /// <summary>
    /// The time at which the driver ended the assignment. If the assignment is current, this value will be omitted.
    /// </summary>
    [JsonPropertyName("endMs")]
    public long? EndMs { get; set; }

    /// <summary>
    /// The time at which the driver started the assignment
    /// </summary>
    [JsonPropertyName("startMs")]
    public long? StartMs { get; set; }

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
