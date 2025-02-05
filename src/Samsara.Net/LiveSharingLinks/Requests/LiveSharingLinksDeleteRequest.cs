using Samsara.Net.Core;

namespace Samsara.Net.LiveSharingLinks;

public record LiveSharingLinksDeleteRequest
{
    /// <summary>
    /// Unique identifier for the Live Sharing Link.
    /// </summary>
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
