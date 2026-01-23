using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Alerts;

[Serializable]
public record GetConfigurationsRequest
{
    /// <summary>
    /// Filter by the IDs. Returns all if no ids are provided.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// The status of the alert configuration.  Valid values: `all`, `enabled`, `disabled`
    /// </summary>
    [JsonIgnore]
    public GetConfigurationsRequestStatus? Status { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Optional boolean indicating whether to return external IDs on supported entities
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
