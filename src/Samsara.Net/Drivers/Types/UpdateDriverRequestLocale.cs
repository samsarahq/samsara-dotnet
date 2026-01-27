using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers;

[JsonConverter(typeof(StringEnumSerializer<UpdateDriverRequestLocale>))]
[Serializable]
public readonly record struct UpdateDriverRequestLocale : IStringEnum
{
    public static readonly UpdateDriverRequestLocale Us = new(Values.Us);

    public static readonly UpdateDriverRequestLocale At = new(Values.At);

    public static readonly UpdateDriverRequestLocale Be = new(Values.Be);

    public static readonly UpdateDriverRequestLocale Ca = new(Values.Ca);

    public static readonly UpdateDriverRequestLocale Gb = new(Values.Gb);

    public static readonly UpdateDriverRequestLocale Fr = new(Values.Fr);

    public static readonly UpdateDriverRequestLocale De = new(Values.De);

    public static readonly UpdateDriverRequestLocale Ie = new(Values.Ie);

    public static readonly UpdateDriverRequestLocale It = new(Values.It);

    public static readonly UpdateDriverRequestLocale Lu = new(Values.Lu);

    public static readonly UpdateDriverRequestLocale Mx = new(Values.Mx);

    public static readonly UpdateDriverRequestLocale Nl = new(Values.Nl);

    public static readonly UpdateDriverRequestLocale Es = new(Values.Es);

    public static readonly UpdateDriverRequestLocale Ch = new(Values.Ch);

    public static readonly UpdateDriverRequestLocale Pr = new(Values.Pr);

    public UpdateDriverRequestLocale(string value)
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
    public static UpdateDriverRequestLocale FromCustom(string value)
    {
        return new UpdateDriverRequestLocale(value);
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

    public static bool operator ==(UpdateDriverRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UpdateDriverRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UpdateDriverRequestLocale value) => value.Value;

    public static explicit operator UpdateDriverRequestLocale(string value) => new(value);

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
