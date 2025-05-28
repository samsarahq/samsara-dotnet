using Samsara.Net.Core;
using Samsara.Net.Reports.Drivers.FuelEnergy;

namespace Samsara.Net.Reports.Drivers;

public partial class DriversClient
{
    private RawClient _client;

    internal DriversClient(RawClient client)
    {
        _client = client;
        FuelEnergy = new FuelEnergyClient(_client);
    }

    public FuelEnergyClient FuelEnergy { get; }
}
