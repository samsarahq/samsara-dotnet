using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormsPolymorphicUserObjectResponseBody
{
    /// <summary>
    /// ID of the polymorphic user.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The type of the polymorphic user.  Valid values: `driver`, `user`
    /// </summary>
    [JsonPropertyName("type")]
    public required FormsPolymorphicUserObjectResponseBodyType Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
