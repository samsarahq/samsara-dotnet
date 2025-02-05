using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverAppSettingsTrailerSelectionConfigTinyObjectRequestBody
{
    /// <summary>
    /// Allow drivers to create new trailers in the Samsara Driver app.
    /// </summary>
    [JsonPropertyName("driverTrailerCreationEnabled")]
    public bool? DriverTrailerCreationEnabled { get; set; }

    /// <summary>
    /// Trailer selection limit.
    /// </summary>
    [JsonPropertyName("maxNumOfTrailersSelected")]
    public int? MaxNumOfTrailersSelected { get; set; }

    /// <summary>
    /// Allow drivers to search for trailers outside of their selection tag when connected to the internet
    /// </summary>
    [JsonPropertyName("orgTrailerSearch")]
    public bool? OrgTrailerSearch { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
