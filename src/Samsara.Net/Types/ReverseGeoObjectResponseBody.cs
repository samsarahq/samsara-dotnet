using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record ReverseGeoObjectResponseBody
{
    /// <summary>
    /// Formatted address of the reverse geocoding data.
    /// </summary>
    [JsonPropertyName("formattedLocation")]
    public string? FormattedLocation { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
