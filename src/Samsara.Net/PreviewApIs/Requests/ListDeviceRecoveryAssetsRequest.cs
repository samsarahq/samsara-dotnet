using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record ListDeviceRecoveryAssetsRequest
{
    /// <summary>
    /// Filter by one or more recovery statuses. Only assets matching the specified statuses will be returned. Returns all statuses if not specified.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<ListDeviceRecoveryAssetsRequestStatusesItem> Statuses { get; set; } =
        new List<ListDeviceRecoveryAssetsRequestStatusesItem>();

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
