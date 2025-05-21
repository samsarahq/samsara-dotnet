using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A location object for the job
/// </summary>
public record PostJobObjectjobLocationRequestObjectRequestBody
{
    /// <summary>
    /// Address of a location
    /// </summary>
    [JsonPropertyName("address")]
    public required string Address { get; set; }

    /// <summary>
    /// Latitude of a location
    /// </summary>
    [JsonPropertyName("latitude")]
    public required double Latitude { get; set; }

    /// <summary>
    /// Longitude of a location
    /// </summary>
    [JsonPropertyName("longitude")]
    public required double Longitude { get; set; }

    /// <summary>
    /// Name of the location
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

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
