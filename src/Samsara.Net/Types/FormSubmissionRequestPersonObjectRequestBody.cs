using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record FormSubmissionRequestPersonObjectRequestBody
{
    /// <summary>
    /// Samsara polymorphicUserID of the person.
    /// </summary>
    [JsonPropertyName("polymorphicUserId")]
    public required string PolymorphicUserId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
