using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Context details of the Function run execution.
/// </summary>
[Serializable]
public record FunctionRunContextResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique request identifier for the execution.
    /// </summary>
    [JsonPropertyName("requestId")]
    public required string RequestId { get; set; }

    /// <summary>
    /// The request payload sent to the Function.
    /// </summary>
    [JsonPropertyName("requestPayload")]
    public Dictionary<string, object?>? RequestPayload { get; set; }

    /// <summary>
    /// The response payload returned by the Function.
    /// </summary>
    [JsonPropertyName("responsePayload")]
    public Dictionary<string, object?>? ResponsePayload { get; set; }

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
