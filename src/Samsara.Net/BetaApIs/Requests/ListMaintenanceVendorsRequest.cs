using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[Serializable]
public record ListMaintenanceVendorsRequest
{
    /// <summary>
    /// A comma-separated list of up to 100 vendor IDs to filter on. Accepts Samsara UUIDs or external IDs in key:value format. The default external ID key is samsara.vendorId (e.g. samsara.vendorId:V-12345). See [external IDs](https://developers.samsara.com/docs/external-ids).
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Ids { get; set; } = new List<string>();

    /// <summary>
    /// When true, include externalIds on each vendor in the response. Default false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeExternalIds { get; set; }

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
