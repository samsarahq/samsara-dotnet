using Samsara.Net.Core;
using Samsara.Net.Settings.Compliance;
using Samsara.Net.Settings.DriverApp;
using Samsara.Net.Settings.Safety;

namespace Samsara.Net.Settings;

public partial class SettingsClient
{
    private RawClient _client;

    internal SettingsClient(RawClient client)
    {
        _client = client;
        Compliance = new ComplianceClient(_client);
        DriverApp = new DriverAppClient(_client);
        Safety = new SafetyClient(_client);
    }

    public ComplianceClient Compliance { get; }

    public DriverAppClient DriverApp { get; }

    public SafetyClient Safety { get; }
}
