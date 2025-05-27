using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Cameras.Media.Retrieval;

public record RetrievalGetRequest
{
    /// <summary>
    /// Retrieval ID associated with this media capture request. Examples: 2308cec4-82e0-46f1-8b3c-a3592e5cc21e
    /// </summary>
    [JsonIgnore]
    public required string RetrievalId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
