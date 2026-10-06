using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityUpdatePartTypeResponseBodyPartStatus>))]
[Serializable]
public readonly record struct EntityUpdatePartTypeResponseBodyPartStatus : IStringEnum
{
    public static readonly EntityUpdatePartTypeResponseBodyPartStatus Unknown = new(Values.Unknown);

    public static readonly EntityUpdatePartTypeResponseBodyPartStatus Active = new(Values.Active);

    public static readonly EntityUpdatePartTypeResponseBodyPartStatus Archived = new(
        Values.Archived
    );

    public static readonly EntityUpdatePartTypeResponseBodyPartStatus Deleted = new(Values.Deleted);

    public EntityUpdatePartTypeResponseBodyPartStatus(string value)
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
    public static EntityUpdatePartTypeResponseBodyPartStatus FromCustom(string value)
    {
        return new EntityUpdatePartTypeResponseBodyPartStatus(value);
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
        EntityUpdatePartTypeResponseBodyPartStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdatePartTypeResponseBodyPartStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EntityUpdatePartTypeResponseBodyPartStatus value) =>
        value.Value;

    public static explicit operator EntityUpdatePartTypeResponseBodyPartStatus(string value) =>
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
