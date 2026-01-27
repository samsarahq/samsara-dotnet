namespace Samsara.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class MethodNotAllowedError(object body)
    : SamsaraClientApiException("MethodNotAllowedError", 405, body);
