using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Hubs;

[Serializable]
public record HubLocationsUpdateHubLocationRequestBody
{
    /// <summary>
    /// The unique Samsara ID of the hub location to update
    /// </summary>
    [JsonIgnore]
    public required string Id { get; set; }

    [JsonPropertyName("data")]
    public required UpdateHubLocationRequestBodyRequestBody Data { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
