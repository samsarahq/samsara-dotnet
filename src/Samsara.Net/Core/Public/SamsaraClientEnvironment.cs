namespace Samsara.Net;

public class SamsaraClientEnvironment
{
    public static readonly SamsaraClientEnvironment Production = new SamsaraClientEnvironment
    {
        Api = "https://api.samsara.com",
        Login = "https://login.samsara.com",
    };

    public static readonly SamsaraClientEnvironment EuProduction = new SamsaraClientEnvironment
    {
        Api = "https://api.eu.samsara.com",
        Login = "https://login.samsara.com",
    };

    /// <summary>
    /// URL for the api service
    /// </summary>
    public string Api { get; init; }

    /// <summary>
    /// URL for the login service
    /// </summary>
    public string Login { get; init; }
}
