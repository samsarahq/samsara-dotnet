using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record PatchDriverVehicleAssignmentsV2RequestBodyMetadataRequestBody
{
    /// <summary>
    /// Describes where the external assignment is coming from
    /// </summary>
    [JsonPropertyName("sourceName")]
    public string? SourceName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
