using Samsara.Net.Alerts.Configurations;
using Samsara.Net.Alerts.Incidents;
using Samsara.Net.Core;

namespace Samsara.Net.Alerts;

public partial class AlertsClient
{
    private RawClient _client;

    internal AlertsClient(RawClient client)
    {
        _client = client;
        Configurations = new ConfigurationsClient(_client);
        Incidents = new IncidentsClient(_client);
    }

    public ConfigurationsClient Configurations { get; }

    public IncidentsClient Incidents { get; }
}
