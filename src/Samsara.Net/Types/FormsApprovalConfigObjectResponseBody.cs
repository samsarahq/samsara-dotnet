using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Form Template approval configuration object.
/// </summary>
[Serializable]
public record FormsApprovalConfigObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("singleApprovalConfig")]
    public FormsSingleApprovalConfigObjectResponseBody? SingleApprovalConfig { get; set; }

    /// <summary>
    /// Type of approval.  Valid values: `singleApproval`
    /// </summary>
    [JsonPropertyName("type")]
    public required FormsApprovalConfigObjectResponseBodyType Type { get; set; }

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
