using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsAssetObjectResponseBody
{
    /// <summary>
    /// The type of entry for the asset.  Valid values: `tracked`, `untracked`
    /// </summary>
    [JsonPropertyName("entryType")]
    public required FormsAssetObjectResponseBodyEntryType EntryType { get; set; }

    /// <summary>
    /// ID of a tracked asset. Included if 'entryType' is 'tracked'.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of an untracked (i.e. manually entered) asset.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
