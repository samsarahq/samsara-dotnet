using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

[JsonConverter(
    typeof(StringEnumSerializer<EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus>)
)]
[Serializable]
public readonly record struct EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus
    : IStringEnum
{
    public static readonly EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus Unknown =
        new(Values.Unknown);

    public static readonly EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus Created =
        new(Values.Created);

    public static readonly EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus Submitted =
        new(Values.Submitted);

    public static readonly EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus InReview =
        new(Values.InReview);

    public static readonly EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus Approved =
        new(Values.Approved);

    public static readonly EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus Rejected =
        new(Values.Rejected);

    public static readonly EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus Resubmitted =
        new(Values.Resubmitted);

    public static readonly EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus Reimbursed =
        new(Values.Reimbursed);

    public EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus(string value)
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
    public static EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus FromCustom(
        string value
    )
    {
        return new EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus(value);
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
        EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus value
    ) => value.Value;

    public static explicit operator EntityWarrantyClaimsServiceUpdateWarrantyClaimRequestBodyClaimStatus(
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
