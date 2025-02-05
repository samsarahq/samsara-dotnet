using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DvirBaseVehicle
{
    /// <summary>
    /// The vehicle id on which DVIR was done.
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// The vehicle on which DVIR was done.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
