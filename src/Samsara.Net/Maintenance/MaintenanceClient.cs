using Samsara.Net.Core;
using Samsara.Net.Maintenance.ServiceTasks;
using Samsara.Net.Maintenance.WorkOrders;

namespace Samsara.Net.Maintenance;

public partial class MaintenanceClient
{
    private RawClient _client;

    internal MaintenanceClient(RawClient client)
    {
        _client = client;
        ServiceTasks = new ServiceTasksClient(_client);
        WorkOrders = new WorkOrdersClient(_client);
    }

    public ServiceTasksClient ServiceTasks { get; }

    public WorkOrdersClient WorkOrders { get; }
}
