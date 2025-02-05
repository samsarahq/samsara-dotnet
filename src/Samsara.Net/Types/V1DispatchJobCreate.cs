using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DispatchJobCreate
{
    /// <summary>
    /// The address of the job destination, as it would be recognized if provided to maps.google.com. Optional if a valid destination address ID is provided.
    /// </summary>
    [JsonPropertyName("destination_address")]
    public string? DestinationAddress { get; set; }

    /// <summary>
    /// ID of the job destination associated with an address book entry. Optional if valid values are provided for destination address and latitude/longitude. If a valid destination address ID is provided, address/latitude/longitude will be used from the address book entry. Name of the address book entry will only be used if the destination name is not provided.
    /// </summary>
    [JsonPropertyName("destination_address_id")]
    public long? DestinationAddressId { get; set; }

    /// <summary>
    /// Latitude of the destination in decimal degrees. Optional if a valid destination address ID is provided.
    /// </summary>
    [JsonPropertyName("destination_lat")]
    public double? DestinationLat { get; set; }

    /// <summary>
    /// Longitude of the destination in decimal degrees. Optional if a valid destination address ID is provided.
    /// </summary>
    [JsonPropertyName("destination_lng")]
    public double? DestinationLng { get; set; }

    /// <summary>
    /// The name of the job destination. If provided, it will take precedence over the name of the address book entry.
    /// </summary>
    [JsonPropertyName("destination_name")]
    public string? DestinationName { get; set; }

    [JsonPropertyName("external_ids")]
    public object? ExternalIds { get; set; }

    /// <summary>
    /// Notes regarding the details of this job, maximum of 2000 characters; newline characters ('\n')can be used for formatting.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// The time at which the assigned driver is scheduled to arrive at the job destination.
    /// </summary>
    [JsonPropertyName("scheduled_arrival_time_ms")]
    public required long ScheduledArrivalTimeMs { get; set; }

    /// <summary>
    /// The time at which the assigned driver is scheduled to depart from the job destination.
    /// </summary>
    [JsonPropertyName("scheduled_departure_time_ms")]
    public long? ScheduledDepartureTimeMs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
