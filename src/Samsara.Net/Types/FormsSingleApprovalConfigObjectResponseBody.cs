using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Single approval configuration object.
/// </summary>
[Serializable]
public record FormsSingleApprovalConfigObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Indicates whether approver can be manually selected. True by default.
    /// </summary>
    [JsonPropertyName("allowManualApproverSelection")]
    public required bool AllowManualApproverSelection { get; set; }

    [JsonPropertyName("requirements")]
    public required SingleApprovalRequirementsObjectResponseBody Requirements { get; set; }

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
