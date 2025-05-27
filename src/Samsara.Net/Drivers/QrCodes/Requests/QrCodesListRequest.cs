using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers.QrCodes;

public record QrCodesListRequest
{
    /// <summary>
    /// String of comma separated driver IDs. List of driver - QR codes for specified driver(s) will be returned.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> DriverIds { get; set; } = new List<string>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
