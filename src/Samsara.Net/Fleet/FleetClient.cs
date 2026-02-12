using Samsara.Net.Core;

namespace Samsara.Net.Fleet;

public partial class FleetClient : IFleetClient
{
    private RawClient _client;

    internal FleetClient(RawClient client)
    {
        _client = client;
        CarrierProposedAssignments =
            new Samsara.Net.Fleet.CarrierProposedAssignments.CarrierProposedAssignmentsClient(
                _client
            );
        Attributes = new Samsara.Net.Fleet.Attributes.AttributesClient(_client);
    }

    public Samsara.Net.Fleet.CarrierProposedAssignments.ICarrierProposedAssignmentsClient CarrierProposedAssignments { get; }

    public Samsara.Net.Fleet.Attributes.IAttributesClient Attributes { get; }
}
