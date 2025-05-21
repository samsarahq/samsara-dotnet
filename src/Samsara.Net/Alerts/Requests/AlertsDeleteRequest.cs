using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Alerts;

public record AlertsDeleteRequest
{
    /// <summary>
    /// The unqiue Samsara id of the alert configuration.
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
