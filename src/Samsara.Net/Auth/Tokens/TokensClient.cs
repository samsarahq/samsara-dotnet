using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Samsara.Net;
using Samsara.Net.Core;

namespace Samsara.Net.Auth.Tokens;

public partial class TokensClient
{
    private RawClient _client;

    internal TokensClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Exchange an authorization code for access and refresh tokens.
    /// </summary>
    /// <example><code>
    /// await client.Auth.Tokens.CreateAsync(new TokensCreateRequest { GrantType = "authorization_code" });
    /// </code></example>
    public async Task<CreateTokensResponse> CreateAsync(
        TokensCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "oauth2/token",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<CreateTokensResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new SamsaraException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new SamsaraApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Invalidates access tokens and refresh tokens for that organization
    /// </summary>
    /// <example><code>
    /// await client.Auth.Tokens.RevokeAsync(new TokensRevokeRequest { Token = "token" });
    /// </code></example>
    public async Task<CreateTokensResponse> RevokeAsync(
        TokensRevokeRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "oauth2/revoke",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<CreateTokensResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new SamsaraException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new SamsaraApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
