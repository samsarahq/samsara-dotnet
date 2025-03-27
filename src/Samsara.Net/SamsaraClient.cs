using Samsara.Net.Addresses;
using Samsara.Net.Alerts;
using Samsara.Net.Attributes;
using Samsara.Net.Auth;
using Samsara.Net.Beta;
using Samsara.Net.CarrierProposedAssignments;
using Samsara.Net.Coaching;
using Samsara.Net.Contacts;
using Samsara.Net.Core;
using Samsara.Net.Documents;
using Samsara.Net.DriverQrCodes;
using Samsara.Net.Drivers;
using Samsara.Net.DriverVehicleAssignments;
using Samsara.Net.Equipment;
using Samsara.Net.FuelAndEnergy;
using Samsara.Net.Gateways;
using Samsara.Net.HoursOfService;
using Samsara.Net.Idling;
using Samsara.Net.Ifta;
using Samsara.Net.Industrial;
using Samsara.Net.Legacy;
using Samsara.Net.LiveSharingLinks;
using Samsara.Net.LocationAndSpeed;
using Samsara.Net.Maintenance;
using Samsara.Net.OrganizationInfo;
using Samsara.Net.Preview;
using Samsara.Net.Routes;
using Samsara.Net.Safety;
using Samsara.Net.Settings;
using Samsara.Net.TachographEuOnly;
using Samsara.Net.Tags;
using Samsara.Net.Trailers;
using Samsara.Net.Users;
using Samsara.Net.V1;
using Samsara.Net.VehicleLocations;
using Samsara.Net.Vehicles;
using Samsara.Net.VehicleStats;

namespace Samsara.Net;

public partial class SamsaraClient
{
    private readonly RawClient _client;

    public SamsaraClient(
        string? clientId = null,
        string? clientSecret = null,
        ClientOptions? clientOptions = null
    )
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Samsara.Net" },
                { "X-Fern-SDK-Version", Version.Current },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        var tokenProvider = new OAuthTokenProvider(
            clientId,
            clientSecret,
            new AuthClient(new RawClient(clientOptions.Clone()))
        );
        clientOptions.Headers["Authorization"] = new Func<string>(
            () => tokenProvider.GetAccessTokenAsync().Result
        );
        _client = new RawClient(clientOptions);
        Addresses = new AddressesClient(_client);
        Alerts = new AlertsClient(_client);
        LocationAndSpeed = new LocationAndSpeedClient(_client);
        Attributes = new AttributesClient(_client);
        Beta = new BetaClient(_client);
        Coaching = new CoachingClient(_client);
        Contacts = new ContactsClient(_client);
        Maintenance = new MaintenanceClient(_client);
        DriverQrCodes = new DriverQrCodesClient(_client);
        CarrierProposedAssignments = new CarrierProposedAssignmentsClient(_client);
        Documents = new DocumentsClient(_client);
        DriverVehicleAssignments = new DriverVehicleAssignmentsClient(_client);
        Drivers = new DriversClient(_client);
        TachographEuOnly = new TachographEuOnlyClient(_client);
        Legacy = new LegacyClient(_client);
        Equipment = new EquipmentClient(_client);
        HoursOfService = new HoursOfServiceClient(_client);
        FuelAndEnergy = new FuelAndEnergyClient(_client);
        Ifta = new IftaClient(_client);
        Idling = new IdlingClient(_client);
        Routes = new RoutesClient(_client);
        Safety = new SafetyClient(_client);
        Settings = new SettingsClient(_client);
        Trailers = new TrailersClient(_client);
        Vehicles = new VehiclesClient(_client);
        VehicleLocations = new VehicleLocationsClient(_client);
        VehicleStats = new VehicleStatsClient(_client);
        Gateways = new GatewaysClient(_client);
        Industrial = new IndustrialClient(_client);
        LiveSharingLinks = new LiveSharingLinksClient(_client);
        OrganizationInfo = new OrganizationInfoClient(_client);
        Preview = new PreviewClient(_client);
        Tags = new TagsClient(_client);
        Users = new UsersClient(_client);
        Auth = new AuthClient(_client);
        V1 = new V1Client(_client);
    }

    public AddressesClient Addresses { get; init; }

    public AlertsClient Alerts { get; init; }

    public LocationAndSpeedClient LocationAndSpeed { get; init; }

    public AttributesClient Attributes { get; init; }

    public BetaClient Beta { get; init; }

    public CoachingClient Coaching { get; init; }

    public ContactsClient Contacts { get; init; }

    public MaintenanceClient Maintenance { get; init; }

    public DriverQrCodesClient DriverQrCodes { get; init; }

    public CarrierProposedAssignmentsClient CarrierProposedAssignments { get; init; }

    public DocumentsClient Documents { get; init; }

    public DriverVehicleAssignmentsClient DriverVehicleAssignments { get; init; }

    public DriversClient Drivers { get; init; }

    public TachographEuOnlyClient TachographEuOnly { get; init; }

    public LegacyClient Legacy { get; init; }

    public EquipmentClient Equipment { get; init; }

    public HoursOfServiceClient HoursOfService { get; init; }

    public FuelAndEnergyClient FuelAndEnergy { get; init; }

    public IftaClient Ifta { get; init; }

    public IdlingClient Idling { get; init; }

    public RoutesClient Routes { get; init; }

    public SafetyClient Safety { get; init; }

    public SettingsClient Settings { get; init; }

    public TrailersClient Trailers { get; init; }

    public VehiclesClient Vehicles { get; init; }

    public VehicleLocationsClient VehicleLocations { get; init; }

    public VehicleStatsClient VehicleStats { get; init; }

    public GatewaysClient Gateways { get; init; }

    public IndustrialClient Industrial { get; init; }

    public LiveSharingLinksClient LiveSharingLinks { get; init; }

    public OrganizationInfoClient OrganizationInfo { get; init; }

    public PreviewClient Preview { get; init; }

    public TagsClient Tags { get; init; }

    public UsersClient Users { get; init; }

    public AuthClient Auth { get; init; }

    public V1Client V1 { get; init; }
}
