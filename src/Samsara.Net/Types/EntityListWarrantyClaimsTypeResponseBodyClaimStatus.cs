using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityListWarrantyClaimsTypeResponseBodyClaimStatus>))]
[Serializable]
public readonly record struct EntityListWarrantyClaimsTypeResponseBodyClaimStatus : IStringEnum
{
    public static readonly EntityListWarrantyClaimsTypeResponseBodyClaimStatus Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListWarrantyClaimsTypeResponseBodyClaimStatus Created = new(
        Values.Created
    );

    public static readonly EntityListWarrantyClaimsTypeResponseBodyClaimStatus Submitted = new(
        Values.Submitted
    );

    public static readonly EntityListWarrantyClaimsTypeResponseBodyClaimStatus InReview = new(
        Values.InReview
    );

    public static readonly EntityListWarrantyClaimsTypeResponseBodyClaimStatus Approved = new(
        Values.Approved
    );

    public static readonly EntityListWarrantyClaimsTypeResponseBodyClaimStatus Rejected = new(
        Values.Rejected
    );

    public static readonly EntityListWarrantyClaimsTypeResponseBodyClaimStatus Resubmitted = new(
        Values.Resubmitted
    );

    public static readonly EntityListWarrantyClaimsTypeResponseBodyClaimStatus Reimbursed = new(
        Values.Reimbursed
    );

    public EntityListWarrantyClaimsTypeResponseBodyClaimStatus(string value)
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
    public static EntityListWarrantyClaimsTypeResponseBodyClaimStatus FromCustom(string value)
    {
        return new EntityListWarrantyClaimsTypeResponseBodyClaimStatus(value);
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
        EntityListWarrantyClaimsTypeResponseBodyClaimStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListWarrantyClaimsTypeResponseBodyClaimStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListWarrantyClaimsTypeResponseBodyClaimStatus value
    ) => value.Value;

    public static explicit operator EntityListWarrantyClaimsTypeResponseBodyClaimStatus(
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
