using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Equipment.Stats;

public record StatsHistoryRequest
{
    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public required string StartTime { get; set; }

    /// <summary>
    /// An end time in RFC 3339 format. Millisecond precision and timezones are supported. (Examples: 2019-06-13T19:08:25Z, 2019-06-13T19:08:25.455Z, OR 2015-09-15T14:00:12-04:00).
    /// </summary>
    [JsonIgnore]
    public required string EndTime { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of parent tag IDs, for use by orgs with tag hierarchies. Specifying a parent tag will implicitly include all descendent tags of the parent tag. Example: `parentTagIds=345,678`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> ParentTagIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of tag IDs. Example: `tagIds=1234,5678`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> TagIds { get; set; } = new List<string>();

    /// <summary>
    /// A filter on the data based on this comma-separated list of equipment IDs. Example: `equipmentIds=1234,5678`
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> EquipmentIds { get; set; } = new List<string>();

    /// <summary>
    /// The types of equipment stats you want to query. Currently, you may submit up to 4 types.
    ///
    /// - `engineRpm`: The revolutions per minute of the engine.
    /// - `fuelPercents`: The percent of fuel in the unit of equipment.
    /// - `obdEngineSeconds`: The number of seconds the engine has been running as reported directly from on-board diagnostics. This is supported with the following hardware configurations: AG24/AG26 + AOPEN/A9PIN/ACT9/ACT14.
    /// - `gatewayEngineSeconds`: An approximation of the number of seconds the engine has been running since it was new, based on the amount of time the asset gateway has been receiving power with an offset provided manually through the Samsara cloud dashboard. This is supported with the following hardware configurations:
    ///   - AG24/AG26/AG46P + APWR cable ([Auxiliary engine configuration](https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs#UUID-d514abff-d10a-efaf-35d9-e10fa6c4888d) required)
    ///   - AG52 + BPWR/BEQP cable ([Auxiliary engine configuration](https://kb.samsara.com/hc/en-us/articles/360043040512-Auxiliary-Inputs#UUID-d514abff-d10a-efaf-35d9-e10fa6c4888d) required).
    /// - `gatewayJ1939EngineSeconds`: An approximation of the number of seconds the engine has been running since it was new, based on the amount of time the AG26 device is receiving power via J1939/CAT cable and an offset provided manually through the Samsara cloud dashboard.
    /// - `obdEngineStates`: The state of the engine read from on-board diagnostics. Can be `Off`, `On`, or `Idle`.
    /// - `gatewayEngineStates`: An approximation of engine state based on readings the AG26 receives from the aux/digio cable. Can be `Off` or `On`.
    /// - `gpsOdometerMeters`: An approximation of odometer reading based on GPS calculations since the AG26 was activated, and a manual odometer offset provided in the Samsara cloud dashboard. Valid values: `Off`, `On`.
    /// - `gps`: GPS data including lat/long, heading, speed, address book entry (if exists), and a reverse geocoded address.
    /// - `engineTotalIdleTimeMinutes`: Total time in minutes that the engine has been idling.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<StatsHistoryRequestTypesItem> Types { get; set; } =
        new List<StatsHistoryRequestTypesItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
