using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<RidershipPassengersUpdateRidershipPassengerRequestBodyClassification>)
)]
[Serializable]
public readonly record struct RidershipPassengersUpdateRidershipPassengerRequestBodyClassification
    : IStringEnum
{
    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Unknown =
        new(Values.Unknown);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Pk1 =
        new(Values.Pk1);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Pk2 =
        new(Values.Pk2);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Pk3 =
        new(Values.Pk3);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Pk4 =
        new(Values.Pk4);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification K =
        new(Values.K);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade1 =
        new(Values.Grade1);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade2 =
        new(Values.Grade2);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade3 =
        new(Values.Grade3);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade4 =
        new(Values.Grade4);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade5 =
        new(Values.Grade5);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade6 =
        new(Values.Grade6);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade7 =
        new(Values.Grade7);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade8 =
        new(Values.Grade8);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade9 =
        new(Values.Grade9);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade10 =
        new(Values.Grade10);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade11 =
        new(Values.Grade11);

    public static readonly RidershipPassengersUpdateRidershipPassengerRequestBodyClassification Grade12 =
        new(Values.Grade12);

    public RidershipPassengersUpdateRidershipPassengerRequestBodyClassification(string value)
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
    public static RidershipPassengersUpdateRidershipPassengerRequestBodyClassification FromCustom(
        string value
    )
    {
        return new RidershipPassengersUpdateRidershipPassengerRequestBodyClassification(value);
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
        RidershipPassengersUpdateRidershipPassengerRequestBodyClassification value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RidershipPassengersUpdateRidershipPassengerRequestBodyClassification value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RidershipPassengersUpdateRidershipPassengerRequestBodyClassification value
    ) => value.Value;

    public static explicit operator RidershipPassengersUpdateRidershipPassengerRequestBodyClassification(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Pk1 = "pk1";

        public const string Pk2 = "pk2";

        public const string Pk3 = "pk3";

        public const string Pk4 = "pk4";

        public const string K = "k";

        public const string Grade1 = "grade1";

        public const string Grade2 = "grade2";

        public const string Grade3 = "grade3";

        public const string Grade4 = "grade4";

        public const string Grade5 = "grade5";

        public const string Grade6 = "grade6";

        public const string Grade7 = "grade7";

        public const string Grade8 = "grade8";

        public const string Grade9 = "grade9";

        public const string Grade10 = "grade10";

        public const string Grade11 = "grade11";

        public const string Grade12 = "grade12";
    }
}
