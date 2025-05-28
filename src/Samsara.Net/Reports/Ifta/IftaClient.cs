using Samsara.Net.Core;
using Samsara.Net.Reports.Ifta.Jurisdiction;
using Samsara.Net.Reports.Ifta.Vehicle;

namespace Samsara.Net.Reports.Ifta;

public partial class IftaClient
{
    private RawClient _client;

    internal IftaClient(RawClient client)
    {
        _client = client;
        Jurisdiction = new JurisdictionClient(_client);
        Vehicle = new VehicleClient(_client);
    }

    public JurisdictionClient Jurisdiction { get; }

    public VehicleClient Vehicle { get; }
}
