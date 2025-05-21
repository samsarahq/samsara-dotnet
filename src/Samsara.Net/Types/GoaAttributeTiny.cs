using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Attribute properties.
/// </summary>
public record GoaAttributeTiny
{
    /// <summary>
    /// Id of the attribute
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the attribute
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// List of number values associated with the attribute
    /// </summary>
    [JsonPropertyName("numberValues")]
    public IEnumerable<double>? NumberValues { get; set; }

    /// <summary>
    /// List of string values associated with the attribute.
    /// </summary>
    [JsonPropertyName("stringValues")]
    public IEnumerable<string>? StringValues { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
