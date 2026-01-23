using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Safety;

[Serializable]
public record GetSafetyEventsV2Request
{
    /// <summary>
    /// Required string of comma separated Safety Event IDs. Unique Samsara IDs (uuid) of the safety event.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> SafetyEventIds { get; set; } = new List<string>();

    /// <summary>
    /// Indicates whether or not to return expanded “asset” data
    /// </summary>
    [JsonIgnore]
    public bool? IncludeAsset { get; set; }

    /// <summary>
    /// Indicates whether or not to return expanded “driver” data
    /// </summary>
    [JsonIgnore]
    public bool? IncludeDriver { get; set; }

    /// <summary>
    /// Indicates whether or not to return events that are captured by devices with only a Vehicle Gateway (VG) installed.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeVgOnlyEvents { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
