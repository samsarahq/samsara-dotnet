using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Provider request details. This metadata does not create a request or change approval or award status.
/// </summary>
[Serializable]
public record MaintenanceEstimateExternalRequestResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// HTTPS provider URL without embedded credentials; at most 2048 bytes.
    /// </summary>
    [JsonPropertyName("actionUrl")]
    public string? ActionUrl { get; set; }

    /// <summary>
    /// Provider request reference, not an estimate lookup alias or idempotency key; at most 200 characters.
    /// </summary>
    [JsonPropertyName("externalRequestId")]
    public string? ExternalRequestId { get; set; }

    /// <summary>
    /// External provider name; at most 100 characters.
    /// </summary>
    [JsonPropertyName("externalSystem")]
    public string? ExternalSystem { get; set; }

    /// <summary>
    /// Optional display message; at most 500 characters.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

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
