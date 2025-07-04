using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// The trigger of an alert.
/// </summary>
public record WorkflowTriggerObjectRequestBody
{
    [JsonPropertyName("triggerParams")]
    public TriggerParamsObjectRequestBody? TriggerParams { get; set; }

    /// <summary>
    /// The id of the trigger type. Reference the following list for the ids:
    ///
    /// Ambient Temperature = 1003
    /// Asset Reading = 1062
    /// DVIR Submitted for Asset = 5005
    /// Driver Recorded = 5027
    /// Sudden Fuel Level Rise = 5034
    /// Sudden Fuel Level Drop = 5035
    /// Training Assignment Due Soon = 8003
    /// Training Assignment Past Due = 8004
    /// Vehicle Speed = 1000
    /// Fuel Level (Percentage) = 1005
    /// Vehicle DEF Level (Percentage) = 1006
    /// Vehicle Battery = 1007
    /// Gateway Unplugged = 1009
    /// Dashcam Disconnected = 1012
    /// Camera Connector Disconnected = 1046
    /// Asset starts moving = 1013
    /// Inside Geofence = 1014
    /// Outside Geofence = 1020
    /// Unassigned Driving = 1016
    /// Driver HOS Violation = 1018
    /// Vehicle Engine Idle = 1019
    /// Asset Engine On = 1021
    /// Asset Engine Off = 1022
    /// Harsh Event = 1023
    /// Scheduled Maintenance = 1024
    /// Scheduled Maintenance by Odometer = 1025
    /// Scheduled Maintenance by Engine Hours = 1026
    /// Out of Route = 1027
    /// GPS Signal Loss = 1032
    /// Cell Signal Loss = 1033
    /// Fault Code = 1029
    /// Tire Faults = 1043
    /// Gateway Disconnected = 1030
    /// Panic Button = 1034
    /// Tampering Detected = 1045
    /// If vehicle is severely speeding (as defined by your organization) = 5022
    /// Driver Document Submitted = 5009
    /// Driver App Sign In = 5012
    /// Driver App Sign Out = 5013
    /// Geofence Entry = 5016
    /// Geofence Exit = 5017
    /// Route Stop ETA Alert = 5018
    /// Scheduled Date And Time = 8001
    /// </summary>
    [JsonPropertyName("triggerTypeId")]
    public required int TriggerTypeId { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
