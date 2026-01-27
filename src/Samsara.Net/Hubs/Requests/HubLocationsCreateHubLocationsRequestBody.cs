using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Hubs;

[Serializable]
public record HubLocationsCreateHubLocationsRequestBody
{
    /// <summary>
    /// An array of location objects to be created or updated
    /// </summary>
    [JsonPropertyName("data")]
    public IEnumerable<HubLocationInputObjectRequestBody> Data { get; set; } =
        new List<HubLocationInputObjectRequestBody>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
