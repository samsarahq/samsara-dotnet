using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<EntityCreatePurchaseOrderTypeResponseBodyCreationSource>)
)]
[Serializable]
public readonly record struct EntityCreatePurchaseOrderTypeResponseBodyCreationSource : IStringEnum
{
    public static readonly EntityCreatePurchaseOrderTypeResponseBodyCreationSource Unknown = new(
        Values.Unknown
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyCreationSource User = new(
        Values.User
    );

    public static readonly EntityCreatePurchaseOrderTypeResponseBodyCreationSource ScanPackingList =
        new(Values.ScanPackingList);

    public EntityCreatePurchaseOrderTypeResponseBodyCreationSource(string value)
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
    public static EntityCreatePurchaseOrderTypeResponseBodyCreationSource FromCustom(string value)
    {
        return new EntityCreatePurchaseOrderTypeResponseBodyCreationSource(value);
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
        EntityCreatePurchaseOrderTypeResponseBodyCreationSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreatePurchaseOrderTypeResponseBodyCreationSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityCreatePurchaseOrderTypeResponseBodyCreationSource value
    ) => value.Value;

    public static explicit operator EntityCreatePurchaseOrderTypeResponseBodyCreationSource(
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
