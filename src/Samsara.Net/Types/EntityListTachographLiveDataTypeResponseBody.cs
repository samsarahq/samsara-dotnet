using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// TachographLiveData object
/// </summary>
[Serializable]
public record EntityListTachographLiveDataTypeResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The driver's cumulated driving time across the previous and current week, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("cumulatedDrivingTimePreviousAndCurrentWeekMinute")]
    public long? CumulatedDrivingTimePreviousAndCurrentWeekMinute { get; set; }

    /// <summary>
    /// The driver's cumulative break time, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("cumulativeBreakTimeMinute")]
    public long? CumulativeBreakTimeMinute { get; set; }

    /// <summary>
    /// The driver's current daily driving time, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("currentDailyDrivingTimeMinute")]
    public long? CurrentDailyDrivingTimeMinute { get; set; }

    /// <summary>
    /// The duration of the driver's currently selected activity, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("currentDurationOfSelectedActivityMinute")]
    public long? CurrentDurationOfSelectedActivityMinute { get; set; }

    /// <summary>
    /// The driver's current weekly driving time, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("currentWeeklyDrivingTimeMinute")]
    public long? CurrentWeeklyDrivingTimeMinute { get; set; }

    /// <summary>
    /// Samsara ID for the driver.
    /// </summary>
    [JsonPropertyName("driverId")]
    public string? DriverId { get; set; }

    /// <summary>
    /// The expected duration of the driver's next break or rest period, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("durationOfNextBreakRestMinute")]
    public long? DurationOfNextBreakRestMinute { get; set; }

    /// <summary>
    /// The expected duration of the driver's next driving period, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("durationOfNextDrivingPeriodMinute")]
    public long? DurationOfNextDrivingPeriodMinute { get; set; }

    /// <summary>
    /// The timestamp marking the end of the driver's last daily rest period, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("endOfLastDailyRestPeriod")]
    public string? EndOfLastDailyRestPeriod { get; set; }

    /// <summary>
    /// The timestamp marking the end of the driver's last weekly rest period, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("endOfLastWeeklyRestPeriod")]
    public string? EndOfLastWeeklyRestPeriod { get; set; }

    /// <summary>
    /// The timestamp when the tachograph reading was measured.
    /// </summary>
    [JsonPropertyName("happenedAtTime")]
    public string? HappenedAtTime { get; set; }

    /// <summary>
    /// The maximum allowed daily driving time for the driver, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("maximumDailyDrivingTimeMinute")]
    public long? MaximumDailyDrivingTimeMinute { get; set; }

    /// <summary>
    /// The minimum required daily rest duration for the driver, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("minimumDailyRestMinute")]
    public long? MinimumDailyRestMinute { get; set; }

    /// <summary>
    /// The minimum required weekly rest duration for the driver, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("minimumWeeklyRestMinute")]
    public long? MinimumWeeklyRestMinute { get; set; }

    /// <summary>
    /// The number of times the driver has exceeded the 9-hour daily driving time limit, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("numberOfTimes9hDailyDrivingTimesExceeded")]
    public long? NumberOfTimes9HDailyDrivingTimesExceeded { get; set; }

    /// <summary>
    /// The number of reduced daily rest periods the driver has used, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("numberOfUsedReducedDailyRestPeriods")]
    public long? NumberOfUsedReducedDailyRestPeriods { get; set; }

    /// <summary>
    /// Open rest compensation owed from the second week before last, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("openCompensationInSecondWeekBeforeLastMinute")]
    public long? OpenCompensationInSecondWeekBeforeLastMinute { get; set; }

    /// <summary>
    /// Open rest compensation owed from the last week, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("openCompensationInTheLastWeekMinute")]
    public long? OpenCompensationInTheLastWeekMinute { get; set; }

    /// <summary>
    /// Open rest compensation owed from the week before last, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("openCompensationInWeekBeforeLastMinute")]
    public long? OpenCompensationInWeekBeforeLastMinute { get; set; }

    /// <summary>
    /// The driver's remaining driving time across the current two-week period, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("remaining2WeeksDrivingTimeMinute")]
    public long? Remaining2WeeksDrivingTimeMinute { get; set; }

    /// <summary>
    /// The driver's remaining current continuous driving time before a break is required, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("remainingCurrentDrivingTimeMinute")]
    public long? RemainingCurrentDrivingTimeMinute { get; set; }

    /// <summary>
    /// The driver's remaining driving time for the current week, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("remainingDrivingTimeOfCurrentWeekMinute")]
    public long? RemainingDrivingTimeOfCurrentWeekMinute { get; set; }

    /// <summary>
    /// The driver's remaining driving time on the current shift, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("remainingDrivingTimeOnCurrentShiftMinute")]
    public long? RemainingDrivingTimeOnCurrentShiftMinute { get; set; }

    /// <summary>
    /// Time remaining in the driver's current break or rest period, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("remainingTimeOfCurrentBreakRestMinute")]
    public long? RemainingTimeOfCurrentBreakRestMinute { get; set; }

    /// <summary>
    /// Time remaining until the driver's next required break or rest period, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("remainingTimeUntilNextBreakOrRestMinute")]
    public long? RemainingTimeUntilNextBreakOrRestMinute { get; set; }

    /// <summary>
    /// The tachograph card number for the driver.
    /// </summary>
    [JsonPropertyName("tachographCardNumber")]
    public string? TachographCardNumber { get; set; }

    /// <summary>
    /// Time remaining until the driver must begin a new daily rest period, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("timeLeftUntilNewDailyRestPeriodMinute")]
    public long? TimeLeftUntilNewDailyRestPeriodMinute { get; set; }

    /// <summary>
    /// Time remaining until the driver must begin a new weekly rest period, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("timeLeftUntilNewWeeklyRestPeriodMinute")]
    public long? TimeLeftUntilNewWeeklyRestPeriodMinute { get; set; }

    /// <summary>
    /// Time remaining until the driver's next driving period can begin, as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("timeLeftUntilNextDrivingPeriodMinute")]
    public long? TimeLeftUntilNextDrivingPeriodMinute { get; set; }

    /// <summary>
    /// Samsara ID for the vehicle associated with the live tachograph data.
    /// </summary>
    [JsonPropertyName("vehicleId")]
    public string? VehicleId { get; set; }

    /// <summary>
    /// The current working state of the driver (e.g. Rest, Availability, Work, Driving), as defined by ISO 16844-7 (Tachograph - Digital data interface).
    /// </summary>
    [JsonPropertyName("workingState")]
    public string? WorkingState { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
