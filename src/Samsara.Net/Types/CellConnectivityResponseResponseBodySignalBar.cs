using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<CellConnectivityResponseResponseBodySignalBar>))]
[Serializable]
public readonly record struct CellConnectivityResponseResponseBodySignalBar : IStringEnum
{
    public static readonly CellConnectivityResponseResponseBodySignalBar One4 = new(Values.One4);

    public static readonly CellConnectivityResponseResponseBodySignalBar Two4 = new(Values.Two4);

    public static readonly CellConnectivityResponseResponseBodySignalBar Three4 = new(
        Values.Three4
    );

    public static readonly CellConnectivityResponseResponseBodySignalBar Four4 = new(Values.Four4);

    public static readonly CellConnectivityResponseResponseBodySignalBar Unknown = new(
        Values.Unknown
    );

    public CellConnectivityResponseResponseBodySignalBar(string value)
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
    public static CellConnectivityResponseResponseBodySignalBar FromCustom(string value)
    {
        return new CellConnectivityResponseResponseBodySignalBar(value);
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
        CellConnectivityResponseResponseBodySignalBar value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CellConnectivityResponseResponseBodySignalBar value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(CellConnectivityResponseResponseBodySignalBar value) =>
        value.Value;

    public static explicit operator CellConnectivityResponseResponseBodySignalBar(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string One4 = "1/4";

        public const string Two4 = "2/4";

        public const string Three4 = "3/4";

        public const string Four4 = "4/4";

        public const string Unknown = "unknown";
    }
}
