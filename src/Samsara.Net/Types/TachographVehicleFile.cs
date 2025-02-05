using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record TachographVehicleFile
{
    /// <summary>
    /// Creation time of files in RFC 3339 format. This is either the download time from the tachograph itself (for files downloaded via Samsara VG) or upload time (for files manually uploaded via Samsara UI).
    /// </summary>
    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    /// <summary>
    /// ID of the file.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A temporary URL which can be used to download the file. The link can be used multiple times and expires after an hour.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// VIN associated with the vehicle file.
    /// </summary>
    [JsonPropertyName("vehicleIdentificationNumber")]
    public string? VehicleIdentificationNumber { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
