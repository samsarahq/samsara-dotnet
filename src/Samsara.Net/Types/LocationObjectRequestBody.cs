using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A location. Polygon and Circle is deprecated, but may be set for old Alerts. At least one location must be selected.
/// </summary>
public record LocationObjectRequestBody
{
    /// <summary>
    /// All locations with selected address IDs will trigger.
    /// </summary>
    [JsonPropertyName("addressIds")]
    public IEnumerable<string>? AddressIds { get; set; }

    /// <summary>
    /// All locations with the selected address types will trigger.
    /// </summary>
    [JsonPropertyName("addressTypes")]
    public IEnumerable<LocationObjectRequestBodyAddressTypesItem>? AddressTypes { get; set; }

    [JsonPropertyName("circle")]
    public CircleRequestBody? Circle { get; set; }

    [JsonPropertyName("polygon")]
    public PolygonRequestBody? Polygon { get; set; }

    /// <summary>
    /// All locations with selected tag will trigger.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

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
