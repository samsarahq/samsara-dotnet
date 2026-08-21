using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<EntityUpdatePurchaseOrderTypeResponseBodyCreationSource>)
)]
[Serializable]
public readonly record struct EntityUpdatePurchaseOrderTypeResponseBodyCreationSource : IStringEnum
{
    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyCreationSource Unknown = new(
        Values.Unknown
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyCreationSource User = new(
        Values.User
    );

    public static readonly EntityUpdatePurchaseOrderTypeResponseBodyCreationSource ScanPackingList =
        new(Values.ScanPackingList);

    public EntityUpdatePurchaseOrderTypeResponseBodyCreationSource(string value)
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
    public static EntityUpdatePurchaseOrderTypeResponseBodyCreationSource FromCustom(string value)
    {
        return new EntityUpdatePurchaseOrderTypeResponseBodyCreationSource(value);
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
        EntityUpdatePurchaseOrderTypeResponseBodyCreationSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdatePurchaseOrderTypeResponseBodyCreationSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityUpdatePurchaseOrderTypeResponseBodyCreationSource value
    ) => value.Value;

    public static explicit operator EntityUpdatePurchaseOrderTypeResponseBodyCreationSource(
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
