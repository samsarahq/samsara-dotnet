using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ResolvedBy
{
    /// <summary>
    /// The Id of user who is resolving the defect.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The type of user who is resolving the defect. Must be "mechanic".
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
