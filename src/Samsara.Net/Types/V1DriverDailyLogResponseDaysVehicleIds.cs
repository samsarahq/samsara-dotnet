using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DriverDailyLogResponseDaysVehicleIds
{
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
