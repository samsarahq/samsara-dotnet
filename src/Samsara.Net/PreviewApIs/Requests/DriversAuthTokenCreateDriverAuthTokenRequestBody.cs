using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[Serializable]
public record DriversAuthTokenCreateDriverAuthTokenRequestBody
{
    /// <summary>
    /// Required. Random 12+ character string, used with the auth token to help secure the client from intercepted tokens.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>
    /// Optional. External ID of the driver, in the format `key:value` (e.g., `payrollId:ABFS18600`). One of `id`, `externalId`, or `username` is required.
    /// </summary>
    [JsonPropertyName("externalId")]
    public string? ExternalId { get; set; }

    /// <summary>
    /// Optional. Samsara ID of the driver. One of `id`, `externalId`, or `username` is required.
    /// </summary>
    [JsonPropertyName("id")]
    public long? Id { get; set; }

    /// <summary>
    /// Optional. Username of the driver. This is the login identifier configured when the driver is created. One of `id`, `externalId`, or `username` is required.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
