using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CoachableEventResponseBody
{
    /// <summary>
    /// Unique ID for an event within the item in a coaching session.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
