using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityListIssuesTypeResponseBodyType>))]
[Serializable]
public readonly record struct EntityListIssuesTypeResponseBodyType : IStringEnum
{
    public static readonly EntityListIssuesTypeResponseBodyType Unknown = new(Values.Unknown);

    public static readonly EntityListIssuesTypeResponseBodyType Pothole = new(Values.Pothole);

    public static readonly EntityListIssuesTypeResponseBodyType RoadCracking = new(
        Values.RoadCracking
    );

    public static readonly EntityListIssuesTypeResponseBodyType PatchedPothole = new(
        Values.PatchedPothole
    );

    public static readonly EntityListIssuesTypeResponseBodyType TransverseCrack = new(
        Values.TransverseCrack
    );

    public static readonly EntityListIssuesTypeResponseBodyType LongitudinalCrack = new(
        Values.LongitudinalCrack
    );

    public static readonly EntityListIssuesTypeResponseBodyType AlligatorCrack = new(
        Values.AlligatorCrack
    );

    public static readonly EntityListIssuesTypeResponseBodyType UtilityCut = new(Values.UtilityCut);

    public static readonly EntityListIssuesTypeResponseBodyType SteelPlate = new(Values.SteelPlate);

    public static readonly EntityListIssuesTypeResponseBodyType RepavingNeeded = new(
        Values.RepavingNeeded
    );

    public EntityListIssuesTypeResponseBodyType(string value)
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
    public static EntityListIssuesTypeResponseBodyType FromCustom(string value)
    {
        return new EntityListIssuesTypeResponseBodyType(value);
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

    public static bool operator ==(EntityListIssuesTypeResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EntityListIssuesTypeResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EntityListIssuesTypeResponseBodyType value) =>
        value.Value;

    public static explicit operator EntityListIssuesTypeResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Pothole = "pothole";

        public const string RoadCracking = "roadCracking";

        public const string PatchedPothole = "patchedPothole";

        public const string TransverseCrack = "transverseCrack";

        public const string LongitudinalCrack = "longitudinalCrack";

        public const string AlligatorCrack = "alligatorCrack";

        public const string UtilityCut = "utilityCut";

        public const string SteelPlate = "steelPlate";

        public const string RepavingNeeded = "repavingNeeded";
    }
}
