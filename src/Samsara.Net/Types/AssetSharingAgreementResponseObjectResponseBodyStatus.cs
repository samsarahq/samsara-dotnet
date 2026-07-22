using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<AssetSharingAgreementResponseObjectResponseBodyStatus>))]
[Serializable]
public readonly record struct AssetSharingAgreementResponseObjectResponseBodyStatus : IStringEnum
{
    public static readonly AssetSharingAgreementResponseObjectResponseBodyStatus Pending = new(
        Values.Pending
    );

    public static readonly AssetSharingAgreementResponseObjectResponseBodyStatus Accepted = new(
        Values.Accepted
    );

    public static readonly AssetSharingAgreementResponseObjectResponseBodyStatus Rejected = new(
        Values.Rejected
    );

    public static readonly AssetSharingAgreementResponseObjectResponseBodyStatus Canceled = new(
        Values.Canceled
    );

    public AssetSharingAgreementResponseObjectResponseBodyStatus(string value)
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
    public static AssetSharingAgreementResponseObjectResponseBodyStatus FromCustom(string value)
    {
        return new AssetSharingAgreementResponseObjectResponseBodyStatus(value);
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
        AssetSharingAgreementResponseObjectResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetSharingAgreementResponseObjectResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetSharingAgreementResponseObjectResponseBodyStatus value
    ) => value.Value;

    public static explicit operator AssetSharingAgreementResponseObjectResponseBodyStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Pending = "pending";

        public const string Accepted = "accepted";

        public const string Rejected = "rejected";

        public const string Canceled = "canceled";
    }
}
