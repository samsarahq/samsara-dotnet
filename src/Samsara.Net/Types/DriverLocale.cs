using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DriverLocale>))]
[Serializable]
public readonly record struct DriverLocale : IStringEnum
{
    public static readonly DriverLocale Us = new(Values.Us);

    public static readonly DriverLocale At = new(Values.At);

    public static readonly DriverLocale Be = new(Values.Be);

    public static readonly DriverLocale Ca = new(Values.Ca);

    public static readonly DriverLocale Gb = new(Values.Gb);

    public static readonly DriverLocale Fr = new(Values.Fr);

    public static readonly DriverLocale De = new(Values.De);

    public static readonly DriverLocale Ie = new(Values.Ie);

    public static readonly DriverLocale It = new(Values.It);

    public static readonly DriverLocale Lu = new(Values.Lu);

    public static readonly DriverLocale Mx = new(Values.Mx);

    public static readonly DriverLocale Nl = new(Values.Nl);

    public static readonly DriverLocale Es = new(Values.Es);

    public static readonly DriverLocale Ch = new(Values.Ch);

    public static readonly DriverLocale Pr = new(Values.Pr);

    public DriverLocale(string value)
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
    public static DriverLocale FromCustom(string value)
    {
        return new DriverLocale(value);
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

    public static bool operator ==(DriverLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DriverLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DriverLocale value) => value.Value;

    public static explicit operator DriverLocale(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Us = "us";

        public const string At = "at";

        public const string Be = "be";

        public const string Ca = "ca";

        public const string Gb = "gb";

        public const string Fr = "fr";

        public const string De = "de";

        public const string Ie = "ie";

        public const string It = "it";

        public const string Lu = "lu";

        public const string Mx = "mx";

        public const string Nl = "nl";

        public const string Es = "es";

        public const string Ch = "ch";

        public const string Pr = "pr";
    }
}
