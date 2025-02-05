using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
