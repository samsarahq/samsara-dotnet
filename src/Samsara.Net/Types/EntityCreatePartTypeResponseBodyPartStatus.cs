using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityCreatePartTypeResponseBodyPartStatus>))]
[Serializable]
public readonly record struct EntityCreatePartTypeResponseBodyPartStatus : IStringEnum
{
    public static readonly EntityCreatePartTypeResponseBodyPartStatus Unknown = new(Values.Unknown);

    public static readonly EntityCreatePartTypeResponseBodyPartStatus Active = new(Values.Active);

    public static readonly EntityCreatePartTypeResponseBodyPartStatus Archived = new(
        Values.Archived
    );

    public static readonly EntityCreatePartTypeResponseBodyPartStatus Deleted = new(Values.Deleted);

    public EntityCreatePartTypeResponseBodyPartStatus(string value)
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
    public static EntityCreatePartTypeResponseBodyPartStatus FromCustom(string value)
    {
        return new EntityCreatePartTypeResponseBodyPartStatus(value);
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
        EntityCreatePartTypeResponseBodyPartStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreatePartTypeResponseBodyPartStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EntityCreatePartTypeResponseBodyPartStatus value) =>
        value.Value;

    public static explicit operator EntityCreatePartTypeResponseBodyPartStatus(string value) =>
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
