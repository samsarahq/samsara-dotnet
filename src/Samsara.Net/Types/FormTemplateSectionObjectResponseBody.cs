using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Form Template section object.
/// </summary>
public record FormTemplateSectionObjectResponseBody
{
    /// <summary>
    /// The index of the first field from the fields array that is in this section. Index 0 represents the first field definition of the fields array.
    /// </summary>
    [JsonPropertyName("fieldIndexFirstInclusive")]
    public required long FieldIndexFirstInclusive { get; set; }

    /// <summary>
    /// The index of the last field from the fields array that is in this section.
    /// </summary>
    [JsonPropertyName("fieldIndexLastInclusive")]
    public required long FieldIndexLastInclusive { get; set; }

    /// <summary>
    /// Identifier of the section.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Label of the section.
    /// </summary>
    [JsonPropertyName("label")]
    public required string Label { get; set; }

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
