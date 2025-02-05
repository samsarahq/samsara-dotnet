using Samsara.Net.Core;

namespace Samsara.Net.DriverQrCodes;

public record DriverQrCodesGetRequest
{
    /// <summary>
    /// String of comma separated driver IDs. List of driver - QR codes for specified driver(s) will be returned.
    /// </summary>
    public IEnumerable<string> DriverIds { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
