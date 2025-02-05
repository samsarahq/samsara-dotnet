using Samsara.Net.Core;
using Samsara.Net.V1.Assets;
using Samsara.Net.V1.Dispatch;
using Samsara.Net.V1.Industrial;
using Samsara.Net.V1.Machines;
using Samsara.Net.V1.Messages;
using Samsara.Net.V1.Safety;
using Samsara.Net.V1.Sensors;
using Samsara.Net.V1.TrailerAssignments;
using Samsara.Net.V1.Trips;
using Samsara.Net.V1.Webhooks;

namespace Samsara.Net.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
        Assets = new AssetsClient(_client);
        Dispatch = new DispatchClient(_client);
        Messages = new MessagesClient(_client);
        TrailerAssignments = new TrailerAssignmentsClient(_client);
        Trips = new TripsClient(_client);
        Safety = new SafetyClient(_client);
        Industrial = new IndustrialClient(_client);
        Machines = new MachinesClient(_client);
        Sensors = new SensorsClient(_client);
        Webhooks = new WebhooksClient(_client);
    }

    public AssetsClient Assets { get; }

    public DispatchClient Dispatch { get; }

    public MessagesClient Messages { get; }

    public TrailerAssignmentsClient TrailerAssignments { get; }

    public TripsClient Trips { get; }

    public SafetyClient Safety { get; }

    public IndustrialClient Industrial { get; }

    public MachinesClient Machines { get; }

    public SensorsClient Sensors { get; }

    public WebhooksClient Webhooks { get; }
}
