using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Ifta.Csv;

public record IftaCreateIftaDetailJobRequestBody
{
    /// <summary>
    /// An end time in RFC 3339 format. Hour precision and timezones are supported. Any minutes or seconds will be truncated down to the nearest hour. Note that the most recent 72 hours of data may still be processing and is subject to change and latency, so it is not recommended to request data for the most recent 72 hours. The maximum request duration is 1 month. Limit the number of vehicles to 1000 when requesting more than 24 hours of data. (Examples: 2019-06-13T19:00:00Z, 2019-06-13T19:00:00.000Z, OR 2015-09-15T14:00:00-04:00).
    /// </summary>
    [JsonPropertyName("endHour")]
    public required string EndHour { get; set; }

    /// <summary>
    /// A start time in RFC 3339 format. Hour precision and timezones are supported. Any minutes or seconds will be truncated down to the nearest hour. Note that the most recent 72 hours of data may still be processing and is subject to change and latency, so it is not recommended to request data for the most recent 72 hours. The maximum request duration is 1 month. Limit the number of vehicles to 1000 when requesting more than 24 hours of data. (Examples: 2019-06-13T19:00:00Z, 2019-06-13T19:00:00.000Z, OR 2015-09-15T14:00:00-04:00).
    /// </summary>
    [JsonPropertyName("startHour")]
    public required string StartHour { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of vehicle IDs and external IDs. The number of vehicles requested per job shouldn't exceed 5000. Example: `vehicleIds: '1234,5678,samsara.vin:1HGBH41JXMN109186'`
    /// </summary>
    [JsonPropertyName("vehicleIds")]
    public string? VehicleIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of vehicle parent tag IDs. The number of vehicles requested per job shouldn't exceed 5000. Example: `vehicleParentTagIds: '1234,5678'`
    /// </summary>
    [JsonPropertyName("vehicleParentTagIds")]
    public string? VehicleParentTagIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of vehicle tag IDs. The number of vehicles requested per job shouldn't exceed 5000. Example: `vehicleTagIds: '1234,5678'`
    /// </summary>
    [JsonPropertyName("vehicleTagIds")]
    public string? VehicleTagIds { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
