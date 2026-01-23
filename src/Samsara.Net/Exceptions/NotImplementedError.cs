namespace Samsara.Net;

/// <summary>
/// This exception type will be thrown for any non-2XX API responses.
/// </summary>
[Serializable]
public class NotImplementedError(object body)
    : SamsaraClientApiException("NotImplementedError", 501, body);
