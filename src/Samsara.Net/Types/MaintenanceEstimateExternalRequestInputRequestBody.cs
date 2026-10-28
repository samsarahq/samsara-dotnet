using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Optional provider metadata. Every child is optional. PATCH replaces the whole object, null or an empty object clears it, and omission preserves it. Nonempty provider metadata requires an actual quote or an active selected recommendation.
/// </summary>
[Serializable]
public record MaintenanceEstimateExternalRequestInputRequestBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Optional provider URL. Nonempty values must be HTTPS without embedded credentials, at most 2048 bytes; empty strings are accepted.
    /// </summary>
    [JsonPropertyName("actionUrl")]
    public string? ActionUrl { get; set; }

    /// <summary>
    /// Optional provider request reference, not an estimate alias or idempotency key. Empty strings are accepted.
    /// </summary>
    [JsonPropertyName("externalRequestId")]
    public string? ExternalRequestId { get; set; }

    /// <summary>
    /// Optional external provider name; empty strings are accepted.
    /// </summary>
    [JsonPropertyName("externalSystem")]
    public string? ExternalSystem { get; set; }

    /// <summary>
    /// Optional display message; empty strings are accepted.
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
