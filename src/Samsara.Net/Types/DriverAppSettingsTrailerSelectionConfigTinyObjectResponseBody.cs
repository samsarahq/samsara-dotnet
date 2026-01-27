using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Trailer selection setting configuration for the Driver App.
/// </summary>
[Serializable]
public record DriverAppSettingsTrailerSelectionConfigTinyObjectResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Allow drivers to create new trailers in the Samsara Driver app.
    /// </summary>
    [JsonPropertyName("driverTrailerCreationEnabled")]
    public bool? DriverTrailerCreationEnabled { get; set; }

    /// <summary>
    /// Trailer selection limit.
    /// </summary>
    [JsonPropertyName("maxNumOfTrailersSelected")]
    public long? MaxNumOfTrailersSelected { get; set; }

    /// <summary>
    /// Allow drivers to search for trailers outside of their selection tag when connected to the internet
    /// </summary>
    [JsonPropertyName("orgTrailerSearch")]
    public bool? OrgTrailerSearch { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
