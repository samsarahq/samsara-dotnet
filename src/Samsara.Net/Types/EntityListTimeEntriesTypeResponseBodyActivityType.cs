using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityListTimeEntriesTypeResponseBodyActivityType>))]
[Serializable]
public readonly record struct EntityListTimeEntriesTypeResponseBodyActivityType : IStringEnum
{
    public static readonly EntityListTimeEntriesTypeResponseBodyActivityType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyActivityType Break = new(
        Values.Break
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyActivityType ShopCleaning = new(
        Values.ShopCleaning
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyActivityType PartsHandling = new(
        Values.PartsHandling
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyActivityType OperationalTest = new(
        Values.OperationalTest
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyActivityType EquipmentSetup = new(
        Values.EquipmentSetup
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyActivityType Inspection = new(
        Values.Inspection
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyActivityType RoadCall = new(
        Values.RoadCall
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyActivityType Training = new(
        Values.Training
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyActivityType Administrative = new(
        Values.Administrative
    );

    public static readonly EntityListTimeEntriesTypeResponseBodyActivityType ShopMiscellaneous =
        new(Values.ShopMiscellaneous);

    public EntityListTimeEntriesTypeResponseBodyActivityType(string value)
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
    public static EntityListTimeEntriesTypeResponseBodyActivityType FromCustom(string value)
    {
        return new EntityListTimeEntriesTypeResponseBodyActivityType(value);
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
        EntityListTimeEntriesTypeResponseBodyActivityType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListTimeEntriesTypeResponseBodyActivityType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListTimeEntriesTypeResponseBodyActivityType value
    ) => value.Value;

    public static explicit operator EntityListTimeEntriesTypeResponseBodyActivityType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Break = "break";

        public const string ShopCleaning = "shopCleaning";

        public const string PartsHandling = "partsHandling";

        public const string OperationalTest = "operationalTest";

        public const string EquipmentSetup = "equipmentSetup";

        public const string Inspection = "inspection";

        public const string RoadCall = "roadCall";

        public const string Training = "training";

        public const string Administrative = "administrative";

        public const string ShopMiscellaneous = "shopMiscellaneous";
    }
}
