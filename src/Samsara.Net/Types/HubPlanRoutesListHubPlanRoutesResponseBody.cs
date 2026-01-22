using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[Serializable]
public record HubPlanRoutesListHubPlanRoutesResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Route data
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<RouteObjectResponseBody> Data { get; set; } =
        new List<RouteObjectResponseBody>();

    [JsonPropertyName("pagination")]
    public required ListHubPlanRoutesResponsePaginationResponseBody Pagination { get; set; }

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
