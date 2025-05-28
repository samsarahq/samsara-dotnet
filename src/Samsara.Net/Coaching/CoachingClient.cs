using Samsara.Net.Coaching.DriverCoachAssignments;
using Samsara.Net.Coaching.Sessions;
using Samsara.Net.Core;

namespace Samsara.Net.Coaching;

public partial class CoachingClient
{
    private RawClient _client;

    internal CoachingClient(RawClient client)
    {
        _client = client;
        DriverCoachAssignments = new DriverCoachAssignmentsClient(_client);
        Sessions = new SessionsClient(_client);
    }

    public DriverCoachAssignmentsClient DriverCoachAssignments { get; }

    public SessionsClient Sessions { get; }
}
