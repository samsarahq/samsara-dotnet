namespace Samsara.Net.Fleet;

public partial interface IFleetClient
{
    public Samsara.Net.Fleet.CarrierProposedAssignments.ICarrierProposedAssignmentsClient CarrierProposedAssignments { get; }
    public Samsara.Net.Fleet.Attributes.IAttributesClient Attributes { get; }
}
