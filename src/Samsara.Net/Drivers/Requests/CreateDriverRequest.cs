using System.Text.Json.Serialization;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers;

[Serializable]
public record CreateDriverRequest
{
    [JsonPropertyName("attributes")]
    public IEnumerable<CreateDriverRequestAttributes>? Attributes { get; set; }

    [JsonPropertyName("carrierSettings")]
    public DriverCarrierSettings? CarrierSettings { get; set; }

    /// <summary>
    /// The ID Card Code on the back of the physical card assigned to the driver.  Contact Samsara if you would like to enable this feature.
    /// </summary>
    [JsonPropertyName("currentIdCardCode")]
    public string? CurrentIdCardCode { get; set; }

    /// <summary>
    /// Flag indicating this driver may use Adverse Weather exemptions in ELD logs.
    /// </summary>
    [JsonPropertyName("eldAdverseWeatherExemptionEnabled")]
    public bool? EldAdverseWeatherExemptionEnabled { get; set; }

    /// <summary>
    /// Flag indicating this driver may use Big Day exemption in ELD logs.
    /// </summary>
    [JsonPropertyName("eldBigDayExemptionEnabled")]
    public bool? EldBigDayExemptionEnabled { get; set; }

    /// <summary>
    /// `0` indicating midnight-to-midnight ELD driving hours, `12` to indicate noon-to-noon driving hours.
    /// </summary>
    [JsonPropertyName("eldDayStartHour")]
    public long? EldDayStartHour { get; set; }

    /// <summary>
    /// Flag indicating this driver is exempt from the Electronic Logging Mandate.
    /// </summary>
    [JsonPropertyName("eldExempt")]
    public bool? EldExempt { get; set; }

    /// <summary>
    /// Reason that this driver is exempt from the Electronic Logging Mandate (see eldExempt).
    /// </summary>
    [JsonPropertyName("eldExemptReason")]
    public string? EldExemptReason { get; set; }

    /// <summary>
    /// Flag indicating this driver may select the Personal Conveyance duty status in ELD logs.
    /// </summary>
    [JsonPropertyName("eldPcEnabled")]
    public bool? EldPcEnabled { get; set; }

    /// <summary>
    /// Flag indicating this driver may select the Yard Move duty status in ELD logs.
    /// </summary>
    [JsonPropertyName("eldYmEnabled")]
    public bool? EldYmEnabled { get; set; }

    /// <summary>
    /// The [external IDs](https://developers.samsara.com/docs/external-ids) for the given object.
    /// </summary>
    [JsonPropertyName("externalIds")]
    public Dictionary<string, string>? ExternalIds { get; set; }

    [JsonPropertyName("hasDrivingFeaturesHidden")]
    public bool? HasDrivingFeaturesHidden { get; set; }

    [JsonPropertyName("hasVehicleUnpinningEnabled")]
    public bool? HasVehicleUnpinningEnabled { get; set; }

    [JsonPropertyName("hosSetting")]
    public DriverHosSetting? HosSetting { get; set; }

    /// <summary>
    /// Driver's state issued license number. The combination of this number and `licenseState` must be unique.
    /// </summary>
    [JsonPropertyName("licenseNumber")]
    public string? LicenseNumber { get; set; }

    /// <summary>
    /// Abbreviation of US state, Canadian province, or US territory that issued driver's license.
    /// </summary>
    [JsonPropertyName("licenseState")]
    public string? LicenseState { get; set; }

    /// <summary>
    /// Locale override (uncommon). These are specified by ISO 3166-2 country codes for supported locales. Valid values: `us`, `at`, `be`, `ca`, `gb`, `fr`, `de`, `ie`, `it`, `lu`, `mx`, `nl`, `es`, `ch`, `pr`.
    /// </summary>
    [JsonPropertyName("locale")]
    public CreateDriverRequestLocale? Locale { get; set; }

    /// <summary>
    /// Driver's name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Notes about the driver.
    /// </summary>
    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <summary>
    /// Password that the driver can use to login to the Samsara driver app.
    /// </summary>
    [JsonPropertyName("password")]
    public required string Password { get; set; }

    /// <summary>
    /// The peer group tag id this driver belong to, used for gamification.
    /// </summary>
    [JsonPropertyName("peerGroupTagId")]
    public string? PeerGroupTagId { get; set; }

    /// <summary>
    /// Phone number of the driver.
    /// </summary>
    [JsonPropertyName("phone")]
    public string? Phone { get; set; }

    [JsonPropertyName("profileImageBase64")]
    public string? ProfileImageBase64 { get; set; }

    [JsonPropertyName("profileImageUrl")]
    public string? ProfileImageUrl { get; set; }

    /// <summary>
    /// ID of vehicle that the driver is permanently assigned to. (uncommon).
    /// </summary>
    [JsonPropertyName("staticAssignedVehicleId")]
    public string? StaticAssignedVehicleId { get; set; }

    /// <summary>
    /// Driver's assigned tachograph card number (Europe specific)
    /// </summary>
    [JsonPropertyName("tachographCardNumber")]
    public string? TachographCardNumber { get; set; }

    /// <summary>
    /// IDs of tags the driver is associated with. If your access to the API is scoped by one or more tags, this field is required to pass in.
    /// </summary>
    [JsonPropertyName("tagIds")]
    public IEnumerable<string>? TagIds { get; set; }

    /// <summary>
    /// Home terminal timezone, in order to indicate what time zone should be used to calculate the ELD logs. Driver timezones use [IANA timezone database](https://www.iana.org/time-zones) keys (e.g. `America/Los_Angeles`, `America/New_York`, `Europe/London`, etc.). You can find a mapping of common timezone formats to IANA timezone keys [here](https://unicode.org/cldr/charts/latest/supplemental/zone_tzid.html).
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    [JsonPropertyName("usDriverRulesetOverride")]
    public UsDriverRulesetOverride? UsDriverRulesetOverride { get; set; }

    /// <summary>
    /// Driver's login username into the driver app. The username may not contain spaces or the '@' symbol. The username must be unique.
    /// </summary>
    [JsonPropertyName("username")]
    public required string Username { get; set; }

    /// <summary>
    /// Tag ID which determines which vehicles a driver will see when selecting vehicles.
    /// </summary>
    [JsonPropertyName("vehicleGroupTagId")]
    public string? VehicleGroupTagId { get; set; }

    /// <summary>
    /// Flag indicating this driver may select waiting time duty status in ELD logs
    /// </summary>
    [JsonPropertyName("waitingTimeDutyStatusEnabled")]
    public bool? WaitingTimeDutyStatusEnabled { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
