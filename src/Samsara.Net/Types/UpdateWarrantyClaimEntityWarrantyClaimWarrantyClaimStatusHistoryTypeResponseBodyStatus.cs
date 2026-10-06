using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus>)
)]
[Serializable]
public readonly record struct UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus
    : IStringEnum
{
    public static readonly UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Unknown =
        new(Values.Unknown);

    public static readonly UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Created =
        new(Values.Created);

    public static readonly UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Submitted =
        new(Values.Submitted);

    public static readonly UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus InReview =
        new(Values.InReview);

    public static readonly UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Approved =
        new(Values.Approved);

    public static readonly UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Rejected =
        new(Values.Rejected);

    public static readonly UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Resubmitted =
        new(Values.Resubmitted);

    public static readonly UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Reimbursed =
        new(Values.Reimbursed);

    public UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus(
        string value
    )
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
    public static UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus FromCustom(
        string value
    )
    {
        return new UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus(
            value
        );
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
        UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus value
    ) => value.Value;

    public static explicit operator UpdateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Created = "created";

        public const string Submitted = "submitted";

        public const string InReview = "inReview";

        public const string Approved = "approved";

        public const string Rejected = "rejected";

        public const string Resubmitted = "resubmitted";

        public const string Reimbursed = "reimbursed";
    }
}
