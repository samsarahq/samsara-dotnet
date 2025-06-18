using Samsara.Net.Auth.Tokens;
using Samsara.Net.Core;

namespace Samsara.Net.Auth;

public partial class AuthClient
{
    private RawClient _client;

    internal AuthClient(RawClient client)
    {
        _client = client;
        Tokens = new TokensClient(_client);
    }

    public TokensClient Tokens { get; }
}
