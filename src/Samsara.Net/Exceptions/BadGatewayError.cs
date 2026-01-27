namespace Samsara.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class BadGatewayError(object body) : SamsaraClientApiException("BadGatewayError", 502, body);
