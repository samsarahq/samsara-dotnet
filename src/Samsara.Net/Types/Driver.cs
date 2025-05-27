using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// A driver object
/// </summary>
public record Driver
{
    /// <summary>
    /// A minified attribute
    /// </summary>
    [JsonPropertyName("attributes")]
    public IEnumerable<AttributeTiny>? Attributes { get; set; }

    [JsonPropertyName("carrierSettings")]
    public DriverCarrierSettings? CarrierSettings { get; set; }

    [JsonPropertyName("createdAtTime")]
    public string? CreatedAtTime { get; set; }

    [JsonPropertyName("currentIdCardCode")]
    public string? CurrentIdCardCode { get; set; }

    [JsonPropertyName("driverActivationStatus")]
    public DriverActivationStatus? DriverActivationStatus { get; set; }

    [JsonPropertyName("eldAdverseWeatherExemptionEnabled")]
    public bool? EldAdverseWeatherExemptionEnabled { get; set; }

    [JsonPropertyName("eldBigDayExemptionEnabled")]
    public bool? EldBigDayExemptionEnabled { get; set; }

    [JsonPropertyName("eldDayStartHour")]
    public int? EldDayStartHour { get; set; }

    [JsonPropertyName("eldExempt")]
    public bool? EldExempt { get; set; }

    [JsonPropertyName("eldExemptReason")]
    public string? EldExemptReason { get; set; }

    [JsonPropertyName("eldPcEnabled")]
    public bool? EldPcEnabled { get; set; }

    [JsonPropertyName("eldSettings")]
    public DriverEldSettings? EldSettings { get; set; }

    [JsonPropertyName("eldYmEnabled")]
    public bool? EldYmEnabled { get; set; }

    [JsonPropertyName("externalIds")]
    public object? ExternalIds { get; set; }

    [JsonPropertyName("hasDrivingFeaturesHidden")]
    public bool? HasDrivingFeaturesHidden { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isDeactivated")]
    public bool? IsDeactivated { get; set; }

    [JsonPropertyName("licenseNumber")]
    public string? LicenseNumber { get; set; }

    [JsonPropertyName("licenseState")]
    public string? LicenseState { get; set; }

    [JsonPropertyName("locale")]
    public DriverLocale? Locale { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("peerGroupTag")]
    public TagTinyResponse? PeerGroupTag { get; set; }

    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("staticAssignedVehicle")]
    public DriverStaticAssignedVehicle? StaticAssignedVehicle { get; set; }

    [JsonPropertyName("tachographCardNumber")]
    public string? TachographCardNumber { get; set; }

    [JsonPropertyName("tags")]
    public IEnumerable<TagTinyResponse>? Tags { get; set; }

    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    [JsonPropertyName("updatedAtTime")]
    public string? UpdatedAtTime { get; set; }

    [JsonPropertyName("usDriverRulesetOverride")]
    public UsDriverRulesetOverride? UsDriverRulesetOverride { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }

    [JsonPropertyName("vehicleGroupTag")]
    public DriverVehicleGroupTag? VehicleGroupTag { get; set; }

    [JsonPropertyName("waitingTimeDutyStatusEnabled")]
    public bool? WaitingTimeDutyStatusEnabled { get; set; }

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
