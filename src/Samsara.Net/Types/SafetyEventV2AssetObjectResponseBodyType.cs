using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<SafetyEventV2AssetObjectResponseBodyType>))]
[Serializable]
public readonly record struct SafetyEventV2AssetObjectResponseBodyType : IStringEnum
{
    public static readonly SafetyEventV2AssetObjectResponseBodyType Uncategorized = new(
        Values.Uncategorized
    );

    public static readonly SafetyEventV2AssetObjectResponseBodyType Trailer = new(Values.Trailer);

    public static readonly SafetyEventV2AssetObjectResponseBodyType Equipment = new(
        Values.Equipment
    );

    public static readonly SafetyEventV2AssetObjectResponseBodyType Unpowered = new(
        Values.Unpowered
    );

    public static readonly SafetyEventV2AssetObjectResponseBodyType Vehicle = new(Values.Vehicle);

    public SafetyEventV2AssetObjectResponseBodyType(string value)
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
    public static SafetyEventV2AssetObjectResponseBodyType FromCustom(string value)
    {
        return new SafetyEventV2AssetObjectResponseBodyType(value);
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
        SafetyEventV2AssetObjectResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SafetyEventV2AssetObjectResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SafetyEventV2AssetObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator SafetyEventV2AssetObjectResponseBodyType(string value) =>
        new(value);

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
