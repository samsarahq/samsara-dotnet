using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DataInputListResponse
{
    /// <summary>
    /// An array of data input data points. Each object in the array represents a data input and will contain its associated data points.
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<DataInputResponse>? Data { get; set; }

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
