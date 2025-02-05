using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record SettingsComplianceResponseObjectResponseBody
{
    /// <summary>
    /// [deprecated] Allow Unregulated Vehicles. This setting is deprecated as all organizations can now mark vehicles as unregulated.
    /// </summary>
    [JsonPropertyName("allowUnregulatedVehiclesEnabled")]
    public bool? AllowUnregulatedVehiclesEnabled { get; set; }

    /// <summary>
    /// Enable Canada HOS
    /// </summary>
    [JsonPropertyName("canadaHosEnabled")]
    public bool? CanadaHosEnabled { get; set; }

    /// <summary>
    /// Carrier name of the organization
    /// </summary>
    [JsonPropertyName("carrierName")]
    public string? CarrierName { get; set; }

    /// <summary>
    /// DOT Number
    /// </summary>
    [JsonPropertyName("dotNumber")]
    public long? DotNumber { get; set; }

    /// <summary>
    /// Enable Driver Auto-Duty
    /// </summary>
    [JsonPropertyName("driverAutoDutyEnabled")]
    public bool? DriverAutoDutyEnabled { get; set; }

    /// <summary>
    /// Drivers Can Edit Certified Log
    /// </summary>
    [JsonPropertyName("editCertifiedLogsEnabled")]
    public bool? EditCertifiedLogsEnabled { get; set; }

    /// <summary>
    /// Force Manual Location For Duty Status Changes
    /// </summary>
    [JsonPropertyName("forceManualLocationForDutyStatusChangesEnabled")]
    public bool? ForceManualLocationForDutyStatusChangesEnabled { get; set; }

    /// <summary>
    /// Force Review of Unassigned HOS
    /// </summary>
    [JsonPropertyName("forceReviewUnassignedHosEnabled")]
    public bool? ForceReviewUnassignedHosEnabled { get; set; }

    /// <summary>
    /// Office Address
    /// </summary>
    [JsonPropertyName("mainOfficeFormattedAddress")]
    public string? MainOfficeFormattedAddress { get; set; }

    /// <summary>
    /// Persistent Duty Status
    /// </summary>
    [JsonPropertyName("persistentDutyStatusEnabled")]
    public bool? PersistentDutyStatusEnabled { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
