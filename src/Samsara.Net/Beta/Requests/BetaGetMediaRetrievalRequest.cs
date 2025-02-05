using Samsara.Net.Core;

namespace Samsara.Net.Beta;

public record BetaGetMediaRetrievalRequest
{
    /// <summary>
    /// Retrieval ID associated with this media capture request. Examples: 2308cec4-82e0-46f1-8b3c-a3592e5cc21e
    /// </summary>
    public required string RetrievalId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
