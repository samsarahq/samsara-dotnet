using Samsara.Net.Core;
using Samsara.Net.Tachograph.Driver;
using Samsara.Net.Tachograph.Vehicles;

namespace Samsara.Net.Tachograph;

public partial class TachographClient
{
    private RawClient _client;

    internal TachographClient(RawClient client)
    {
        _client = client;
        Driver = new DriverClient(_client);
        Vehicles = new VehiclesClient(_client);
    }

    public DriverClient Driver { get; }

    public VehiclesClient Vehicles { get; }
}
