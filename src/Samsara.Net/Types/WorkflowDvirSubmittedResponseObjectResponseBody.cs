using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Details specific to DVIR Submitted.
/// </summary>
[Serializable]
public record WorkflowDvirSubmittedResponseObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("driver")]
    public GoaDriverTinyResponseResponseBody? Driver { get; set; }

    [JsonPropertyName("dvir")]
    public WorkflowDvirObjectResponseBody? Dvir { get; set; }

    [JsonPropertyName("vehicle")]
    public VehicleWithGatewayTinyResponseResponseBody? Vehicle { get; set; }

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
