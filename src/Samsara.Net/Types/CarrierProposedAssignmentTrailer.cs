using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CarrierProposedAssignmentTrailer
{
    /// <summary>
    /// ID of the trailer.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Name of the trailer.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
