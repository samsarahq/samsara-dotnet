using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DefectTypesResponseDataResponseBodySectionType>))]
[Serializable]
public readonly record struct DefectTypesResponseDataResponseBodySectionType : IStringEnum
{
    public static readonly DefectTypesResponseDataResponseBodySectionType ExteriorFront = new(
        Values.ExteriorFront
    );

    public static readonly DefectTypesResponseDataResponseBodySectionType ExteriorRear = new(
        Values.ExteriorRear
    );

    public static readonly DefectTypesResponseDataResponseBodySectionType ExteriorSideUnderneath =
        new(Values.ExteriorSideUnderneath);

    public static readonly DefectTypesResponseDataResponseBodySectionType InteriorDriverCab = new(
        Values.InteriorDriverCab
    );

    public static readonly DefectTypesResponseDataResponseBodySectionType InteriorPassengerArea =
        new(Values.InteriorPassengerArea);

    public static readonly DefectTypesResponseDataResponseBodySectionType Other = new(Values.Other);

    public static readonly DefectTypesResponseDataResponseBodySectionType Unknown = new(
        Values.Unknown
    );

    public DefectTypesResponseDataResponseBodySectionType(string value)
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
    public static DefectTypesResponseDataResponseBodySectionType FromCustom(string value)
    {
        return new DefectTypesResponseDataResponseBodySectionType(value);
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
        DefectTypesResponseDataResponseBodySectionType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DefectTypesResponseDataResponseBodySectionType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DefectTypesResponseDataResponseBodySectionType value) =>
        value.Value;

    public static explicit operator DefectTypesResponseDataResponseBodySectionType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ExteriorFront = "exteriorFront";

        public const string ExteriorRear = "exteriorRear";

        public const string ExteriorSideUnderneath = "exteriorSideUnderneath";

        public const string InteriorDriverCab = "interiorDriverCab";

        public const string InteriorPassengerArea = "interiorPassengerArea";

        public const string Other = "other";

        public const string Unknown = "unknown";
    }
}
