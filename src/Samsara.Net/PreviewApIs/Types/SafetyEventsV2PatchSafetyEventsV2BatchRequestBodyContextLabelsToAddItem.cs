using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[JsonConverter(
    typeof(StringEnumSerializer<SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem>)
)]
[Serializable]
public readonly record struct SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem
    : IStringEnum
{
    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem Congested =
        new(Values.Congested);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem Construction =
        new(Values.Construction);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem CouplingUncoupling =
        new(Values.CouplingUncoupling);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem CyclistMotorcyclist =
        new(Values.CyclistMotorcyclist);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem Defensive =
        new(Values.Defensive);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem Fog =
        new(Values.Fog);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem ImproperSeatBelt =
        new(Values.ImproperSeatBelt);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem LightTraffic =
        new(Values.LightTraffic);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem ModerateTraffic =
        new(Values.ModerateTraffic);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem ModeratelyDrowsy =
        new(Values.ModeratelyDrowsy);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem MountedPhone =
        new(Values.MountedPhone);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem Night =
        new(Values.Night);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem ParkingLot =
        new(Values.ParkingLot);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem PassengerMobileUsage =
        new(Values.PassengerMobileUsage);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem PassengerSleeping =
        new(Values.PassengerSleeping);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem Passengers =
        new(Values.Passengers);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem Pedestrians =
        new(Values.Pedestrians);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem Raining =
        new(Values.Raining);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem SensitiveMedia =
        new(Values.SensitiveMedia);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem SlightlyDrowsy =
        new(Values.SlightlyDrowsy);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem Snowing =
        new(Values.Snowing);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem SnowyRoad =
        new(Values.SnowyRoad);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem SpeedSignVerified =
        new(Values.SpeedSignVerified);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem VeryDrowsy =
        new(Values.VeryDrowsy);

    public static readonly SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem WetRoad =
        new(Values.WetRoad);

    public SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem FromCustom(
        string value
    )
    {
        return new SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(
        SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem value
    ) => value.Value;

    public static explicit operator SafetyEventsV2PatchSafetyEventsV2BatchRequestBodyContextLabelsToAddItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Congested = "Congested";

        public const string Construction = "Construction";

        public const string CouplingUncoupling = "Coupling/Uncoupling";

        public const string CyclistMotorcyclist = "Cyclist/Motorcyclist";

        public const string Defensive = "Defensive";

        public const string Fog = "Fog";

        public const string ImproperSeatBelt = "Improper Seat Belt";

        public const string LightTraffic = "Light Traffic";

        public const string ModerateTraffic = "Moderate Traffic";

        public const string ModeratelyDrowsy = "Moderately Drowsy";

        public const string MountedPhone = "Mounted Phone";

        public const string Night = "Night";

        public const string ParkingLot = "Parking Lot";

        public const string PassengerMobileUsage = "Passenger Mobile Usage";

        public const string PassengerSleeping = "Passenger Sleeping";

        public const string Passengers = "Passengers";

        public const string Pedestrians = "Pedestrians";

        public const string Raining = "Raining";

        public const string SensitiveMedia = "Sensitive Media";

        public const string SlightlyDrowsy = "Slightly Drowsy";

        public const string Snowing = "Snowing";

        public const string SnowyRoad = "Snowy Road";

        public const string SpeedSignVerified = "Speed Sign Verified";

        public const string VeryDrowsy = "Very Drowsy";

        public const string WetRoad = "Wet Road";
    }
}
