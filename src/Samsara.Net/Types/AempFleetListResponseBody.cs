using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record AempFleetListResponseBody
{
    /// <summary>
    /// The list of Equipment objects.
    /// </summary>
    [JsonPropertyName("Equipment")]
    public IEnumerable<AempEquipmentWithAdditionalFieldsResponseBody> Equipment { get; set; } =
        new List<AempEquipmentWithAdditionalFieldsResponseBody>();

    /// <summary>
    /// The list of links associated with the current API request.
    /// </summary>
    [JsonPropertyName("Links")]
    public IEnumerable<AempLinkResponseBody> Links { get; set; } = new List<AempLinkResponseBody>();

    /// <summary>
    /// Date and time at which the snapshot of the fleet was created in RFC 3339 format.
    /// </summary>
    [JsonPropertyName("snapshotTime")]
    public required string SnapshotTime { get; set; }

    /// <summary>
    /// The version of the ISO/TS 15143-3 standard
    /// </summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
