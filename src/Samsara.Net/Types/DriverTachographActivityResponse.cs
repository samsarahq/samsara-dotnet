using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// List of all driver tachograph activities in a specified time range.
/// </summary>
public record DriverTachographActivityResponse
{
    [JsonPropertyName("data")]
    public IEnumerable<TachographActivityListWrapper>? Data { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationResponse? Pagination { get; set; }

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
