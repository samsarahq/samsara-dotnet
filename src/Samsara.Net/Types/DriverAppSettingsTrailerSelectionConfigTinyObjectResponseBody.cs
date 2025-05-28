using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Trailer selection setting configuration for the Driver App.
/// </summary>
public record DriverAppSettingsTrailerSelectionConfigTinyObjectResponseBody
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
