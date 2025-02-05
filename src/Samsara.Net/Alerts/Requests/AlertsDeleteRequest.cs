using Samsara.Net.Core;

namespace Samsara.Net.Alerts;

public record AlertsDeleteRequest
{
    /// <summary>
    /// The unqiue Samsara id of the alert configuration.
    /// </summary>
    public required string Id { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
