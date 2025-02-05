using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ExtendedDriverTinyResponse
{
    /// <summary>
    /// The [external IDs](https://developers.samsara.com/docs/external-ids) for the given object.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public ExtendedDriverTinyResponseExternalIds? ExternalIds { get; set; }

    /// <summary>
    /// ID of the driver.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the driver.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Username of the driver.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
