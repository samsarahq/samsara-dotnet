using Samsara.Net.Core;
using Samsara.Net.Reports.Vehicles.FuelEnergy;
using Samsara.Net.Reports.Vehicles.Idling;

namespace Samsara.Net.Reports.Vehicles;

public partial class VehiclesClient
{
    private RawClient _client;

    internal VehiclesClient(RawClient client)
    {
        _client = client;
        Idling = new IdlingClient(_client);
        FuelEnergy = new FuelEnergyClient(_client);
    }

    public IdlingClient Idling { get; }

    public FuelEnergyClient FuelEnergy { get; }
}
