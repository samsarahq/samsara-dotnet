using Samsara.Net;

namespace Samsara.Net.PreviewApIs;

public partial interface IPreviewApIsClient
{
    /// <summary>
    /// List all assets that have a device recovery state for the organization. Optionally filter by one or more statuses (UNKNOWN, MISSING, LOCATED, RECOVERED).
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<DeviceRecoveryListDeviceRecoveryAssetsResponseBody> ListDeviceRecoveryAssetsAsync(
        ListDeviceRecoveryAssetsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Mark an asset as missing. Optionally specify a note and notification recipients who will receive email updates.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<DeviceRecoveryMarkAssetMissingResponseBody> MarkAssetMissingAsync(
        DeviceRecoveryMarkAssetMissingRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Mark a missing asset as recovered. Provide the recovery status, reason for being missing, and optional additional details.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<DeviceRecoveryRecoverAssetResponseBody> RecoverAssetAsync(
        DeviceRecoveryRecoverAssetRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get the current recovery state for a specific asset, including recovery photos and notification recipients.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Assets** under the Assets category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<DeviceRecoveryGetAssetRecoveryStateResponseBody> GetAssetRecoveryStateAsync(
        GetAssetRecoveryStateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a short-lived auth token for a driver.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Driver Auth Token** under the Drivers category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<DriversAuthTokenCreateDriverAuthTokenResponseBody> CreateDriverAuthTokenAsync(
        DriversAuthTokenCreateDriverAuthTokenRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Lock a vehicle. This requires a vehicle gateway with locking capabilities.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Vehicle Lock/Unlock** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    Task LockVehicleAsync(
        LockVehicleRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Unlock a vehicle.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Vehicle Lock/Unlock** under the Vehicles category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    /// Endpoints in this section are in Preview. These APIs are not functional and are instead for soliciting feedback from our API users on the intended design of this API. Additionally, it is not guaranteed that we will be releasing an endpoint included in this section to production. This means that developers should **NOT** rely on these APIs to build business critical applications
    ///
    /// - Samsara may change the structure of a preview API's interface without versioning or any notice to API users.
    ///
    /// - When an endpoint becomes generally available, it will be announced in the API [changelog](https://developers.samsara.com/changelog).
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    Task UnlockVehicleAsync(
        UnlockVehicleRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
