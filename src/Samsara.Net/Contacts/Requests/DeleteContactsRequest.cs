using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Contacts;

[Serializable]
public record DeleteContactsRequest
{
    /// <summary>
    /// Unique identifier for the contact.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
