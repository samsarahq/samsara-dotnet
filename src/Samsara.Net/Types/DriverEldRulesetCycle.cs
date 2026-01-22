using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DriverEldRulesetCycle>))]
[Serializable]
public readonly record struct DriverEldRulesetCycle : IStringEnum
{
    public static readonly DriverEldRulesetCycle Usa60Hour7Day = new(Values.Usa60Hour7Day);

    public static readonly DriverEldRulesetCycle Usa70Hour8Day = new(Values.Usa70Hour8Day);

    public static readonly DriverEldRulesetCycle Ak80Hour8Day = new(Values.Ak80Hour8Day);

    public static readonly DriverEldRulesetCycle Ak70Hour7Day = new(Values.Ak70Hour7Day);

    public static readonly DriverEldRulesetCycle Ca80Hour8Day = new(Values.Ca80Hour8Day);

    public static readonly DriverEldRulesetCycle Ca112Hour8Day = new(Values.Ca112Hour8Day);

    public static readonly DriverEldRulesetCycle Fl80Hour8Day = new(Values.Fl80Hour8Day);

    public static readonly DriverEldRulesetCycle Fl70Hour7Day = new(Values.Fl70Hour7Day);

    public static readonly DriverEldRulesetCycle Ne80Hour8Day = new(Values.Ne80Hour8Day);

    public static readonly DriverEldRulesetCycle Ne70Hour7Day = new(Values.Ne70Hour7Day);

    public static readonly DriverEldRulesetCycle Nc80Hour8Day = new(Values.Nc80Hour8Day);

    public static readonly DriverEldRulesetCycle Nc70Hour7Day = new(Values.Nc70Hour7Day);

    public static readonly DriverEldRulesetCycle Ok70Hour8Day = new(Values.Ok70Hour8Day);

    public static readonly DriverEldRulesetCycle Ok60Hour7Day = new(Values.Ok60Hour7Day);

    public static readonly DriverEldRulesetCycle Or80Hour8Day = new(Values.Or80Hour8Day);

    public static readonly DriverEldRulesetCycle Or70Hour7Day = new(Values.Or70Hour7Day);

    public static readonly DriverEldRulesetCycle Sc80Hour8Day = new(Values.Sc80Hour8Day);

    public static readonly DriverEldRulesetCycle Sc70Hour7Day = new(Values.Sc70Hour7Day);

    public static readonly DriverEldRulesetCycle Tx70Hour7Day = new(Values.Tx70Hour7Day);

    public static readonly DriverEldRulesetCycle Wi80Hour8Day = new(Values.Wi80Hour8Day);

    public static readonly DriverEldRulesetCycle Wi70Hour7Day = new(Values.Wi70Hour7Day);

    public static readonly DriverEldRulesetCycle CanadaSouthCycle170Hour7Day = new(
        Values.CanadaSouthCycle170Hour7Day
    );

    public static readonly DriverEldRulesetCycle CanadaSouthCycle2120Hour14Day = new(
        Values.CanadaSouthCycle2120Hour14Day
    );

    public static readonly DriverEldRulesetCycle CanadaNorthCycle180Hour7Day = new(
        Values.CanadaNorthCycle180Hour7Day
    );

    public static readonly DriverEldRulesetCycle CanadaNorthCycle2120Hour14Day = new(
        Values.CanadaNorthCycle2120Hour14Day
    );

    public DriverEldRulesetCycle(string value)
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
    public static DriverEldRulesetCycle FromCustom(string value)
    {
        return new DriverEldRulesetCycle(value);
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

    public static bool operator ==(DriverEldRulesetCycle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DriverEldRulesetCycle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DriverEldRulesetCycle value) => value.Value;

    public static explicit operator DriverEldRulesetCycle(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Usa60Hour7Day = "USA 60 hour / 7 day";

        public const string Usa70Hour8Day = "USA 70 hour / 8 day";

        public const string Ak80Hour8Day = "AK 80 hour / 8 day";

        public const string Ak70Hour7Day = "AK 70 hour / 7 day";

        public const string Ca80Hour8Day = "CA 80 hour / 8 day";

        public const string Ca112Hour8Day = "CA 112 hour / 8 day";

        public const string Fl80Hour8Day = "FL 80 hour / 8 day";

        public const string Fl70Hour7Day = "FL 70 hour / 7 day";

        public const string Ne80Hour8Day = "NE 80 hour / 8 day";

        public const string Ne70Hour7Day = "NE 70 hour / 7 day";

        public const string Nc80Hour8Day = "NC 80 hour / 8 day";

        public const string Nc70Hour7Day = "NC 70 hour / 7 day";

        public const string Ok70Hour8Day = "OK 70 hour / 8 day";

        public const string Ok60Hour7Day = "OK 60 hour / 7 day";

        public const string Or80Hour8Day = "OR 80 hour / 8 day";

        public const string Or70Hour7Day = "OR 70 hour / 7 day";

        public const string Sc80Hour8Day = "SC 80 hour / 8 day";

        public const string Sc70Hour7Day = "SC 70 hour / 7 day";

        public const string Tx70Hour7Day = "TX 70 hour / 7 day";

        public const string Wi80Hour8Day = "WI 80 hour / 8 day";

        public const string Wi70Hour7Day = "WI 70 hour / 7 day";

        public const string CanadaSouthCycle170Hour7Day = "Canada South Cycle 1 (70 hour / 7 day)";

        public const string CanadaSouthCycle2120Hour14Day =
            "Canada South Cycle 2 (120 hour / 14 day)";

        public const string CanadaNorthCycle180Hour7Day = "Canada North Cycle 1 (80 hour / 7 day)";

        public const string CanadaNorthCycle2120Hour14Day =
            "Canada North Cycle 2 (120 hour / 14 day)";
    }
}
