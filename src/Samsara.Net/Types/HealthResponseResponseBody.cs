using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Health information for the device.
/// </summary>
public record HealthResponseResponseBody
{
    [JsonPropertyName("healthDetails")]
    public HealthDetailsResponseResponseBody? HealthDetails { get; set; }

    /// <summary>
    /// The list of active health reasons affecting this device.
    /// </summary>
    [JsonPropertyName("healthReasons")]
    public IEnumerable<HealthReasonResponseResponseBody>? HealthReasons { get; set; }

    /// <summary>
    /// Current overall health status of the device.  Valid values: `dataPending`, `healthy`, `needsAttention`, `needsReplacement`
    /// </summary>
    [JsonPropertyName("healthStatus")]
    public HealthResponseResponseBodyHealthStatus? HealthStatus { get; set; }

    /// <summary>
    /// Primary health reason affecting the device's current health status.  Valid values: `assetUnplugged`, `cameraMisaligned`, `healthy`, `inwardCameraObstruction`, `irregularRecording`, `lowDeviceBattery`, `missingEldDiagnostics`, `missingVin`, `needsReplacement`, `newlyInstalledDevice`, `noGpsSignal`, `notDetected`, `outwardCameraObstruction`, `recordingTimeRequired`, `unknown`, `vgUnplugged`
    /// </summary>
    [JsonPropertyName("primaryHealthReason")]
    public HealthResponseResponseBodyPrimaryHealthReason? PrimaryHealthReason { get; set; }

    /// <summary>
    /// The timestamp when the primary health reason began, in RFC3339 format.
    /// </summary>
    [JsonPropertyName("primaryHealthReasonStartTime")]
    public DateTime? PrimaryHealthReasonStartTime { get; set; }

    /// <summary>
    /// Recommended steps to resolve the current health reason.
    ///
    /// * `recommendedActionAgHealthy`: Gateway is healthy. No action required.
    /// * `recommendedActionAgLowDeviceBatteryAG45`: The gateway battery is low. Please contact support
    /// * `recommendedActionAgLowDeviceBatteryAG46`: The gateway battery is low. Gateway batteries require replacement.
    /// * `recommendedActionAgLowDeviceBatteryAG51`: Gateway batteries require replacement.
    /// * `recommendedActionAgLowDeviceBatteryPoweredAG`: The gateway battery is low. Power on the asset to charge the gateway.
    /// * `recommendedActionAgNoGpsSignal`: Gateway has no GPS signal. Verify that the gateway is securely attached to the exterior of the asset. Ensure that the device is outside and avoid obstructions such as underground structures, heavily insulated buildings, bridges, and trees.
    /// * `recommendedActionAgNotDetected`: The gateway has not been detected for at least 24 hours. See troubleshooting steps to reboot the gateway.
    /// * `recommendedActionAgUnplugged`: The asset gateway is unplugged or cut. Check the gateway connection to ensure it is plugged in and has been installed correctly
    /// * `recommendedActionCmCameraMisaligned`: The position of the road-facing dash cam is not aligned with the horizon. Video quality and AI detection may be impacted. Reposition dash cam and Test Dash Cam Positioning.
    /// * `recommendedActionCmHealthy`: Dash cam recording is healthy. No action required.
    /// * `recommendedActionCmInwardCameraObstruction`: The inward-facing dash cam does not have a clear view of the vehicle cab. Video quality and AI detection may be impacted. Remove obstruction and Test Dash Cam Positioning.
    /// * `recommendedActionCmIrregularRecording`: The dash cam is not working as expected. Please contact Support.
    /// * `recommendedActionCmNewlyInstalledDevice`: This dash cam has recently been installed and at least 30 hours of recording time is required to calculate health. No action required.
    /// * `recommendedActionCmNotDetected`: The dash cam has not been detected for at least 24 hours. Check the dash cam's connection and verify your dash cam has been installed correctly.
    /// * `recommendedActionCmOutwardCameraObstruction`: The outward-facing dash cam does not have a clear view of the road. Video quality and AI detection may be impacted Remove obstruction and Test Dash Cam Positioning.
    /// * `recommendedActionCmRecordingTimeRequired`: At least 30 hours of recording time is required to determine device health. No action required.
    /// * `recommendedActionCmVgUnplugged`: The vehicle gateway is unplugged and the dash cam health cannot be determined. Check the vehicle gateway connection and ensure it is plugged in and has been installed correctly.
    /// * `recommendedActionGatewayNewlyInstalledDevice`: This gateway has recently been installed and more data is required to calculate health. No action required.
    /// * `recommendedActionVgHealthy`: Gateway is healthy. No action required.
    /// * `recommendedActionVgMissingEldDiagnostics`: To ensure full compliance, request exchange.
    /// * `recommendedActionVgMissingEldDiagnosticsExchangeSubmitted`: Exchange submitted. Please allow 12-24 hours for exchange to appear in the orders and exchanges page.
    /// * `recommendedActionVgMissingEldDiagnosticsHardwareExchanged`: Install exchanged hardware.
    /// * `recommendedActionVgMissingEldDiagnosticsNoExchangeSubmitted`: To ensure full compliance, request exchange.
    /// * `recommendedActionVgMissingVin`: Add the VIN to your vehicle.
    /// * `recommendedActionVgNeedsReplacement`: To ensure full compliance, request exchange.
    /// * `recommendedActionVgNotDetected`: The vehicle gateway has not been detected for at least 24 hours. Check the vehicle gateway connection to ensure it is plugged in and view additional troubleshooting steps.
    /// * `recommendedActionVgVgUnplugged`: The vehicle gateway is unplugged. Check the vehicle gateway connection to ensure it is plugged in and has been installed correctly.
    /// * `unknown`: None
    ///
    ///
    ///   Valid values: `recommendedActionAgHealthy`, `recommendedActionAgLowDeviceBatteryAG45`, `recommendedActionAgLowDeviceBatteryAG46`, `recommendedActionAgLowDeviceBatteryAG51`, `recommendedActionAgLowDeviceBatteryPoweredAG`, `recommendedActionAgNoGpsSignal`, `recommendedActionAgNotDetected`, `recommendedActionAgUnplugged`, `recommendedActionCmCameraMisaligned`, `recommendedActionCmHealthy`, `recommendedActionCmInwardCameraObstruction`, `recommendedActionCmIrregularRecording`, `recommendedActionCmNewlyInstalledDevice`, `recommendedActionCmNotDetected`, `recommendedActionCmOutwardCameraObstruction`, `recommendedActionCmRecordingTimeRequired`, `recommendedActionCmVgUnplugged`, `recommendedActionGatewayNewlyInstalledDevice`, `recommendedActionVgHealthy`, `recommendedActionVgMissingEldDiagnostics`, `recommendedActionVgMissingEldDiagnosticsExchangeSubmitted`, `recommendedActionVgMissingEldDiagnosticsHardwareExchanged`, `recommendedActionVgMissingEldDiagnosticsNoExchangeSubmitted`, `recommendedActionVgMissingVin`, `recommendedActionVgNeedsReplacement`, `recommendedActionVgNotDetected`, `recommendedActionVgVgUnplugged`, `unknown`
    /// </summary>
    [JsonPropertyName("recommendedAction")]
    public HealthResponseResponseBodyRecommendedAction? RecommendedAction { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
