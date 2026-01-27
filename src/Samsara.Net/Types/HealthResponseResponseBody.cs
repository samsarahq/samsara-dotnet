using System.Text.Json;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

/// <summary>
/// Health information for the device.
/// </summary>
[Serializable]
public record HealthResponseResponseBody : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
    /// Primary health reason affecting the device's current health status.  Valid values: `assetUnplugged`, `cameraMisaligned`, `dataPending`, `healthy`, `inwardCameraObstruction`, `irregularRecording`, `lowDeviceBattery`, `missingEldDiagnostics`, `missingVin`, `needsReplacement`, `newlyInstalledDevice`, `noGpsSignal`, `notDetected`, `outwardCameraObstruction`, `recordingTimeRequired`, `unknown`, `vgUnplugged`
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
    /// * `recommendedActionBLEDataPending`: This device has recently been installed and more data is required to calculate health. No action required.
    /// * `recommendedActionBLEHealthy`: Device is healthy. No action required.
    /// * `recommendedActionBLELowBattery`: The device battery is low. Please contact support.
    /// * `recommendedActionBLENotDetected`: The device has not been detected by a gateway in the Samsara Network for at least 30 days. Verify that the device is securely attached to the asset, not in a remote area, and minimize obstructions that may disrupt detection by nearby gateways.
    /// * `recommendedActionCcHealthy`: Device is healthy. No action required.
    /// * `recommendedActionCcLowUptime`: Please ensure all cameras are physically connected to the device.
    /// * `recommendedActionCcMediaInputUptime`: Please ensure the camera is properly connected to the device.
    /// * `recommendedActionCcNotDetected`: None
    /// * `recommendedActionCmCameraMisaligned`: The position of the road-facing dash cam is not aligned with the horizon. Video quality and AI detection may be impacted. Reposition dash cam and Test Dash Cam Positioning.
    /// * `recommendedActionCmHealthy`: Dash cam recording is healthy. No action required.
    /// * `recommendedActionCmInactive`: None
    /// * `recommendedActionCmInwardCameraObstruction`: The inward-facing dash cam does not have a clear view of the vehicle cab. Video quality and AI detection may be impacted. Remove obstruction and Test Dash Cam Positioning.
    /// * `recommendedActionCmIrregularRecording`: The dash cam shows no evidence of recording during the expected recording time over the last 30 days. Please contact Support.
    /// * `recommendedActionCmLowUptime`: The dash cam is either experiencing low recording uptime, low connectivity, or both. Please follow the troubleshooting steps and contact Support if issues persist.
    /// * `recommendedActionCmNewlyInstalledDevice`: This dash cam has recently been installed and at least 30 hours of recording time is required to calculate health. No action required.
    /// * `recommendedActionCmNotDetected`: The dash cam has not been detected within the last 30 days. Check the dash cam's connection and verify your dash cam has been installed correctly.
    /// * `recommendedActionCmOutwardCameraObstruction`: The outward-facing dash cam does not have a clear view of the road. Video quality and AI detection may be impacted Remove obstruction and Test Dash Cam Positioning.
    /// * `recommendedActionCmRecordingTimeRequired`: At least 30 hours of recording time is required to determine device health. No action required.
    /// * `recommendedActionCmVgUnplugged`: The vehicle gateway is unplugged and the dash cam health cannot be determined. Check the vehicle gateway connection and ensure it is plugged in and has been installed correctly.
    /// * `recommendedActionGatewayNewlyInstalledDevice`: This gateway has recently been installed and more data is required to calculate health. No action required.
    /// * `recommendedActionHealthy`: Asset is healthy. No action required.
    /// * `recommendedActionLowBatteryVoltage`: Asset has reported low battery voltage. Please contact support.
    /// * `recommendedActionOemNotReporting`: Data for this asset has not been received as expected. Please contact support.
    /// * `recommendedActionVehicleOff`: Asset has reported an expected power-off event, and is healthy. No action required.
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
    ///   Valid values: `recommendedActionAgHealthy`, `recommendedActionAgLowDeviceBatteryAG45`, `recommendedActionAgLowDeviceBatteryAG46`, `recommendedActionAgLowDeviceBatteryAG51`, `recommendedActionAgLowDeviceBatteryPoweredAG`, `recommendedActionAgNoGpsSignal`, `recommendedActionAgNotDetected`, `recommendedActionAgUnplugged`, `recommendedActionBLEDataPending`, `recommendedActionBLEHealthy`, `recommendedActionBLELowBattery`, `recommendedActionBLENotDetected`, `recommendedActionCcHealthy`, `recommendedActionCcLowUptime`, `recommendedActionCcMediaInputUptime`, `recommendedActionCcNotDetected`, `recommendedActionCmCameraMisaligned`, `recommendedActionCmHealthy`, `recommendedActionCmInactive`, `recommendedActionCmInwardCameraObstruction`, `recommendedActionCmIrregularRecording`, `recommendedActionCmLowUptime`, `recommendedActionCmNewlyInstalledDevice`, `recommendedActionCmNotDetected`, `recommendedActionCmOutwardCameraObstruction`, `recommendedActionCmRecordingTimeRequired`, `recommendedActionCmVgUnplugged`, `recommendedActionGatewayNewlyInstalledDevice`, `recommendedActionHealthy`, `recommendedActionLowBatteryVoltage`, `recommendedActionOemNotReporting`, `recommendedActionVehicleOff`, `recommendedActionVgHealthy`, `recommendedActionVgMissingEldDiagnostics`, `recommendedActionVgMissingEldDiagnosticsExchangeSubmitted`, `recommendedActionVgMissingEldDiagnosticsHardwareExchanged`, `recommendedActionVgMissingEldDiagnosticsNoExchangeSubmitted`, `recommendedActionVgMissingVin`, `recommendedActionVgNeedsReplacement`, `recommendedActionVgNotDetected`, `recommendedActionVgVgUnplugged`, `unknown`
    /// </summary>
    [JsonPropertyName("recommendedAction")]
    public HealthResponseResponseBodyRecommendedAction? RecommendedAction { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
