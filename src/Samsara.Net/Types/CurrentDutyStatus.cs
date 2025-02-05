using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record CurrentDutyStatus
{
    /// <summary>
    /// The Hours of Service status type.  If the driver app is disconnected, an empty string will be returned. To reconnect the app and return updated values, drivers should have the app open with good cell service. Valid values: `offDuty`, `sleeperBed`, `driving`, `onDuty`, `yardMove`, `personalConveyance`.
    /// </summary>
    [JsonPropertyName("hosStatusType")]
    public CurrentDutyStatusHosStatusType? HosStatusType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
