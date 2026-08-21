using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<EntityListPurchaseOrdersTypeResponseBodyCreationSource>)
)]
[Serializable]
public readonly record struct EntityListPurchaseOrdersTypeResponseBodyCreationSource : IStringEnum
{
    public static readonly EntityListPurchaseOrdersTypeResponseBodyCreationSource Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyCreationSource User = new(
        Values.User
    );

    public static readonly EntityListPurchaseOrdersTypeResponseBodyCreationSource ScanPackingList =
        new(Values.ScanPackingList);

    public EntityListPurchaseOrdersTypeResponseBodyCreationSource(string value)
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
    public static EntityListPurchaseOrdersTypeResponseBodyCreationSource FromCustom(string value)
    {
        return new EntityListPurchaseOrdersTypeResponseBodyCreationSource(value);
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
        EntityListPurchaseOrdersTypeResponseBodyCreationSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListPurchaseOrdersTypeResponseBodyCreationSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListPurchaseOrdersTypeResponseBodyCreationSource value
    ) => value.Value;

    public static explicit operator EntityListPurchaseOrdersTypeResponseBodyCreationSource(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string User = "User";

        public const string ScanPackingList = "ScanPackingList";
    }
}
