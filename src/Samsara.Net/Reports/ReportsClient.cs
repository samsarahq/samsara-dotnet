using Samsara.Net.Core;
using Samsara.Net.Reports.Drivers;
using Samsara.Net.Reports.Ifta;
using Samsara.Net.Reports.Vehicles;

namespace Samsara.Net.Reports;

public partial class ReportsClient
{
    private RawClient _client;

    internal ReportsClient(RawClient client)
    {
        _client = client;
        Drivers = new DriversClient(_client);
        Ifta = new IftaClient(_client);
        Vehicles = new VehiclesClient(_client);
    }

    public DriversClient Drivers { get; }

    public IftaClient Ifta { get; }

    public VehiclesClient Vehicles { get; }
}
