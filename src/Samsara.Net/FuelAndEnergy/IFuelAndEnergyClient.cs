using Samsara.Net;

namespace Samsara.Net.FuelAndEnergy;

public partial interface IFuelAndEnergyClient
{
    /// <summary>
    /// This endpoint will return driver efficiency data that has been collected for your organization and grouped by drivers based on the time parameters passed in. Results are paginated.
    ///
    /// **Note:** The data from this endpoint comes from the Driver Efficiency (Eco-Driving) Report. The existing [/fleet/drivers/efficiency](https://developers.samsara.com/reference/getdriverefficiency) endpoint has now been moved to Legacy.
    ///
    ///  <b>Rate limit:</b> 10 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Driver Efficiency** under the Fuel & Energy category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<DriverEfficiencyGetDriverEfficiencyByDriversResponseBody> GetDriverEfficiencyByDriversAsync(
        GetDriverEfficiencyByDriversRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// This endpoint will return driver efficiency data that has been collected for your organization and grouped by vehicle drivers used based on the time parameters passed in. Results are paginated.
    ///
    /// **Note:** The data from this endpoint comes from the Driver Efficiency (Eco-Driving) Report. The existing [/fleet/drivers/efficiency](https://developers.samsara.com/reference/getdriverefficiency) endpoint has now been moved to Legacy.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Driver Efficiency** under the Fuel & Energy category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<DriverEfficiencyGetDriverEfficiencyByVehiclesResponseBody> GetDriverEfficiencyByVehiclesAsync(
        GetDriverEfficiencyByVehiclesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get fuel and energy efficiency driver reports for the requested time range.
    ///
    ///  <b>Rate limit:</b> 5 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<FuelEnergyGetFuelEnergyDriverReportsResponseBody> GetFuelEnergyDriverReportsAsync(
        GetFuelEnergyDriverReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Get fuel and energy efficiency vehicle reports for the requested time range.
    ///
    ///  <b>Rate limit:</b> 25 requests/sec (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Read Fuel & Energy** under the Fuel & Energy category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<FuelEnergyGetFuelEnergyVehicleReportsResponseBody> GetFuelEnergyVehicleReportsAsync(
        GetFuelEnergyVehicleReportsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a fuel purchase transaction.
    ///
    ///  <b>Rate limit:</b> 100 requests/min (learn more about rate limits <a href="https://developers.samsara.com/docs/rate-limits" target="_blank">here</a>).
    ///
    /// To use this endpoint, select **Write Fuel Purchase** under the Fuel & Energy category when creating or editing an API token. <a href="https://developers.samsara.com/docs/authentication#scopes-for-api-tokens" target="_blank">Learn More.</a>
    ///
    ///
    ///  **Submit Feedback**: Likes, dislikes, and API feature requests should be filed as feedback in our <a href="https://forms.gle/zkD4NCH7HjKb7mm69" target="_blank">API feedback form</a>. If you encountered an issue or noticed inaccuracies in the API documentation, please <a href="https://www.samsara.com/help" target="_blank">submit a case</a> to our support team.
    /// </summary>
    WithRawResponseTask<FuelPurchasePostFuelPurchaseResponseBody> PostFuelPurchaseAsync(
        FuelPurchasePostFuelPurchaseRequestBody request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
