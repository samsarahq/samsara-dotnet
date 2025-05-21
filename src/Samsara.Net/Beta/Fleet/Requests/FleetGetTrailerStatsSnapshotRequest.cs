using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta.Fleet;

public record FleetGetTrailerStatsSnapshotRequest
{
    /// <summary>
    /// The stat types you want this endpoint to return information on.
    ///
    /// You may list **up to 3** types using comma-separated format. For example: `types=gps,reeferAmbientAirTemperatureMilliC,gpsOdometerMeters`.
    ///
    /// * `gps`: GPS data including lat/long, heading, speed, and a reverse geocode address.
    /// * `gpsOdometerMeters`: Odometer reading provided by GPS calculations. You must provide a manual odometer reading before this value is updated. Manual odometer readings can be provided via the PATCH /fleet/trailers/{id} endpoint or through the [cloud dashboard](https://kb.samsara.com/hc/en-us/articles/115005273667-Editing-Odometer-Reading). Odometer readings wthat are manually set will update as GPS trip data is gathered.
    /// * `reeferAmbientAirTemperatureMilliC`: The ambient air temperature reading of the reefer in millidegree Celsius.
    /// * `reeferObdEngineSeconds`: The cumulative number of seconds the reefer has run according to onboard diagnostics. Only supported on reefer solutions.
    /// * `reeferSupplyAirTemperatureMilliCZone1`: The supply or discharge air temperature zone 1 in millidegrees Celsius. For single zone reefers, this applies to the single zone. Only supported on multizone reefer solutions.
    /// * `reeferSupplyAirTemperatureMilliCZone2`: The supply or discharge air temperature zone 2 in millidegrees Celsius. Only supported on multizone reefer solutions.
    /// * `reeferSupplyAirTemperatureMilliCZone3`: The supply or discharge air temperature zone 3 in millidegrees Celsius. Only supported on multizone reefer solutions.
    /// * `reeferFuelPercent`: The fuel level of the reefer unit in percentage points (e.g. `99`, `50`, etc). Only supported on reefer solutions.
    /// * `carrierReeferState`: The overall state of the reefer (`Off`, `On`). Only supported on multizone Carrier reefer solutions.
    /// * `reeferStateZone1`: The state of the reefer in zone 1. For single zone reefers, this applies tot he single zone. Only supported on multizone reefer solutions.
    /// * `reeferStateZone2`: The state of the reefer in zone 2. Only supported on multizone reefer solutions.
    /// * `reeferStateZone3`: The state of the reefer in zone 3. Only supported on multizone reefer solutions.
    /// * `reeferRunMode`: The operational mode of the reefer (`Start/Stop`, `Continuous`)
    /// * `reeferAlarms`: Any alarms that are present on the reefer. Only supported on reefer solutions.
    /// * `reeferReturnAirTemperatureMilliCZone1`: The return air temperature in zone 1 of the reefer in millidegrees Celsius. For single zone reefers, this applies to the single zone. Only supported on multizone reefer solutions.
    /// * `reeferReturnAirTemperatureMilliCZone2`: The return air temperature in zone 2 of the reefer in millidegrees Celsius. Only supported on multizone reefer solutions.
    /// * `reeferReturnAirTemperatureMilliCZone3`: The return air temperature in zone 3 of the reefer in millidegrees Celsius. Only supported on multizone reefer solutions.
    /// * `reeferSetPointTemperatureMilliCZone1`: The set point temperature in zone 1 of the reefer in millidegrees Celsius. For single zone reefers, this applies to the single zone. Only supported on multizone reefer solutions.
    /// * `reeferSetPointTemperatureMilliCZone2`: The set point temperature in zone 2 of the reefer in millidegrees Celsius. Only supported on multizone reefer solutions.
    /// * `reeferSetPointTemperatureMilliCZone3`: The set point temperature in zone 3 of the reefer in millidegrees Celsius. Only supported on multizone reefer solutions.
    /// * `reeferDoorStateZone1`: The door status in zone 1 of the reefer. For single zone reefers, this applies to the single zone.
    /// * `reeferDoorStateZone2`: The door status in zone 2 of the reefer. Only supported on multizone reefer solutions.
    /// * `reeferDoorStateZone3`: The door status in zone 3 of the reefer. Only supported on multizone reefer solutions.
    /// </summary>
    [JsonIgnore]
    public required string Types { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of tag IDs. Example: `tagIds=1234,5678`
    /// </summary>
    [JsonIgnore]
    public string? TagIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of parent tag IDs, for use by orgs with tag hierarchies. Specifying a parent tag will implicitly include all descendent tags of the parent tag. Example: `parentTagIds=345,678`
    /// </summary>
    [JsonIgnore]
    public string? ParentTagIds { get; set; }

    /// <summary>
    /// If specified, this should be the endCursor value from the previous page of results. When present, this request will return the next page of results that occur immediately after the previous page of results.
    /// </summary>
    [JsonIgnore]
    public string? After { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of trailer IDs and externalIds. Example: `trailerIds=1234,5678,samsara.vin:1HGBH41JXMN109186`
    /// </summary>
    [JsonIgnore]
    public string? TrailerIds { get; set; }

    /// <summary>
    /// A filter on the data that returns the last known data points with timestamps less than or equal to this value. Defaults to now if not provided. Must be a string in RFC 3339 Format. Millisecond precision and timezones are supported.
    /// </summary>
    [JsonIgnore]
    public string? Time { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
