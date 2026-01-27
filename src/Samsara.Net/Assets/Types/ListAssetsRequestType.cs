using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Assets;

[JsonConverter(typeof(StringEnumSerializer<ListAssetsRequestType>))]
[Serializable]
public readonly record struct ListAssetsRequestType : IStringEnum
{
    public static readonly ListAssetsRequestType Uncategorized = new(Values.Uncategorized);

    public static readonly ListAssetsRequestType Trailer = new(Values.Trailer);

    public static readonly ListAssetsRequestType Equipment = new(Values.Equipment);

    public static readonly ListAssetsRequestType Unpowered = new(Values.Unpowered);

    public static readonly ListAssetsRequestType Vehicle = new(Values.Vehicle);

    public ListAssetsRequestType(string value)
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
    public static ListAssetsRequestType FromCustom(string value)
    {
        return new ListAssetsRequestType(value);
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

    public static bool operator ==(ListAssetsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListAssetsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListAssetsRequestType value) => value.Value;

    public static explicit operator ListAssetsRequestType(string value) => new(value);

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
