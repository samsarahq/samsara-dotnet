using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Tracked or untracked (i.e. manually entered) person object.
/// </summary>
public record FormsPersonObjectResponseBody
{
    /// <summary>
    /// The type of entry for the person.  Valid values: `tracked`, `untracked`
    /// </summary>
    [JsonPropertyName("entryType")]
    public required FormsPersonObjectResponseBodyEntryType EntryType { get; set; }

    /// <summary>
    /// Name of an untracked (i.e. manually entered) person.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("polymorphicUserId")]
    public FormsPolymorphicUserObjectResponseBody? PolymorphicUserId { get; set; }

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
