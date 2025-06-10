using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Definition of a reading.
/// </summary>
public record ReadingDefinitionResponseBody
{
    /// <summary>
    /// The category enumeration that this reading belongs to.
    /// </summary>
    [JsonPropertyName("category")]
    public required string Category { get; set; }

    /// <summary>
    /// The human readable description for this reading. Translated to English.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// Entity type of this reading.
    /// </summary>
    [JsonPropertyName("entityType")]
    public required string EntityType { get; set; }

    /// <summary>
    /// Array of enumeration values
    /// </summary>
    [JsonPropertyName("enumValues")]
    public IEnumerable<EnumValueResponseBody>? EnumValues { get; set; }

    /// <summary>
    /// The label for this reading that is suitable to show to a user. Translated to English.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

    /// <summary>
    /// The ID of the reading used to fetch time series data in other endpoints.
    /// </summary>
    [JsonPropertyName("readingId")]
    public required string ReadingId { get; set; }

    [JsonPropertyName("type")]
    public required ReadingTypeResponseBody Type { get; set; }

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
