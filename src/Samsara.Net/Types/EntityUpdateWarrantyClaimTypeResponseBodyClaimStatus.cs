using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus>))]
[Serializable]
public readonly record struct EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus : IStringEnum
{
    public static readonly EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus Unknown = new(
        Values.Unknown
    );

    public static readonly EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus Created = new(
        Values.Created
    );

    public static readonly EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus Submitted = new(
        Values.Submitted
    );

    public static readonly EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus InReview = new(
        Values.InReview
    );

    public static readonly EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus Approved = new(
        Values.Approved
    );

    public static readonly EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus Rejected = new(
        Values.Rejected
    );

    public static readonly EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus Resubmitted = new(
        Values.Resubmitted
    );

    public static readonly EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus Reimbursed = new(
        Values.Reimbursed
    );

    public EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus(string value)
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
    public static EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus FromCustom(string value)
    {
        return new EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus(value);
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
        EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus value
    ) => value.Value;

    public static explicit operator EntityUpdateWarrantyClaimTypeResponseBodyClaimStatus(
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
