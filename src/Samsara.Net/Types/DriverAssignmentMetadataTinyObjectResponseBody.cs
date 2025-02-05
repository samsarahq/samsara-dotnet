using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record DriverAssignmentMetadataTinyObjectResponseBody
{
    /// <summary>
    /// Assigned source name from an external source.
    /// </summary>
    [JsonPropertyName("sourceName")]
    public string? SourceName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
