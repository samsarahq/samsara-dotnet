using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Routes.AuditLogs;

public record AuditLogsFeedRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// Expands the specified value(s) in the response object. Expansion populates additional fields in an object, if supported. Unsupported fields are ignored. To expand multiple fields, input a comma-separated list.
    ///
    /// Valid value: `route`  Valid values: `route`
    /// </summary>
    [JsonIgnore]
    public string? Expand { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
