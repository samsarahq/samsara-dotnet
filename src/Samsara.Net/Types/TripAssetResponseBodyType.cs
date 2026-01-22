using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TripAssetResponseBodyType>))]
[Serializable]
public readonly record struct TripAssetResponseBodyType : IStringEnum
{
    public static readonly TripAssetResponseBodyType Uncategorized = new(Values.Uncategorized);

    public static readonly TripAssetResponseBodyType Trailer = new(Values.Trailer);

    public static readonly TripAssetResponseBodyType Equipment = new(Values.Equipment);

    public static readonly TripAssetResponseBodyType Unpowered = new(Values.Unpowered);

    public static readonly TripAssetResponseBodyType Vehicle = new(Values.Vehicle);

    public TripAssetResponseBodyType(string value)
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
    public static TripAssetResponseBodyType FromCustom(string value)
    {
        return new TripAssetResponseBodyType(value);
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

    public static bool operator ==(TripAssetResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TripAssetResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TripAssetResponseBodyType value) => value.Value;

    public static explicit operator TripAssetResponseBodyType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Uncategorized = "uncategorized";

        public const string Trailer = "trailer";

        public const string Equipment = "equipment";

        public const string Unpowered = "unpowered";

        public const string Vehicle = "vehicle";
    }
}
