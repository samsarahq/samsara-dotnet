using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Devices;

public record DevicesListRequest
{
    /// <summary>
    /// Optional string of comma separated device models. Valid values: `CM31`, `CM32`, `CM33`, `CM34`, `VG34`, `VG34M`, `VG34EU`, `VG34FN`, `VG54NA`, `VG54EU`, `VG55NA`, `VG55EU`, `AG24`, `AG24EU`, `AG26`, `AG26EU`, `AG45`, `AG45EU`, `AG46`, `AG46EU`, `AG46P`, `AG46PEU`, `AG51`, `AG51EU`, `AG52`, `AG52EU`, `AG53`, `AG53EU`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Models { get; set; } = new List<string>();

    /// <summary>
    /// Optional string of comma separated device health statuses. Valid values: `healthy`, `needsAttention`, `needsReplacement`, `dataPending`.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> HealthStatuses { get; set; } = new List<string>();

    /// <summary>
    /// Optional boolean to control whether device health information is returned in the response. Defaults to false.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeHealth { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// The limit for how many objects will be in the response. Default and max for this value is 100 objects.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
