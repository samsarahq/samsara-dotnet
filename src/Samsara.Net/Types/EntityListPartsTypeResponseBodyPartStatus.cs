using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityListPartsTypeResponseBodyPartStatus>))]
[Serializable]
public readonly record struct EntityListPartsTypeResponseBodyPartStatus : IStringEnum
{
    public static readonly EntityListPartsTypeResponseBodyPartStatus Unknown = new(Values.Unknown);

    public static readonly EntityListPartsTypeResponseBodyPartStatus Active = new(Values.Active);

    public static readonly EntityListPartsTypeResponseBodyPartStatus Archived = new(
        Values.Archived
    );

    public static readonly EntityListPartsTypeResponseBodyPartStatus Deleted = new(Values.Deleted);

    public EntityListPartsTypeResponseBodyPartStatus(string value)
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
    public static EntityListPartsTypeResponseBodyPartStatus FromCustom(string value)
    {
        return new EntityListPartsTypeResponseBodyPartStatus(value);
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
        EntityListPartsTypeResponseBodyPartStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListPartsTypeResponseBodyPartStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EntityListPartsTypeResponseBodyPartStatus value) =>
        value.Value;

    public static explicit operator EntityListPartsTypeResponseBodyPartStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string Active = "Active";

        public const string Archived = "Archived";

        public const string Deleted = "Deleted";
    }
}
