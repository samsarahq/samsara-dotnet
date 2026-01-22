namespace Samsara.Net.Fleet;

public partial interface IFleetClient
{
    public Samsara.Net.Fleet.Attributes.AttributesClient Attributes { get; }
}
