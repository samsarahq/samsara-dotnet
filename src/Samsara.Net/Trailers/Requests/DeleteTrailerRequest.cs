using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Trailers;

[Serializable]
public record DeleteTrailerRequest
{
    /// <summary>
    /// Unique identifier for the trailer to delete.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
