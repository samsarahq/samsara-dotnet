using Samsara.Net.Addresses;
using Samsara.Net.Alerts;
using Samsara.Net.Assets;
using Samsara.Net.Attributes;
using Samsara.Net.Auth;
using Samsara.Net.Beta;
using Samsara.Net.CarrierProposedAssignments;
using Samsara.Net.Coaching;
using Samsara.Net.Contacts;
using Samsara.Net.Core;
using Samsara.Net.Dispatch;
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
using Samsara.Net.Machines;
using Samsara.Net.Maintenance;
using Samsara.Net.Messages;
using Samsara.Net.OrganizationInfo;
using Samsara.Net.Preview;
using Samsara.Net.Routes;
using Samsara.Net.Safety;
using Samsara.Net.Sensors;
using Samsara.Net.Settings;
using Samsara.Net.TachographEuOnly;
using Samsara.Net.Tags;
using Samsara.Net.TrailerAssignments;
using Samsara.Net.Trailers;
using Samsara.Net.Trips;
using Samsara.Net.Users;
using Samsara.Net.VehicleLocations;
using Samsara.Net.Vehicles;
using Samsara.Net.VehicleStats;
using Samsara.Net.Webhooks;

namespace Samsara.Net;

public partial class SamsaraClient
{
    private readonly RawClient _client;

    public SamsaraClient(string? token = null, ClientOptions? clientOptions = null)
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {token}" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Samsara.Net" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Samsara.Net/0.1.0" },
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
        Assets = new AssetsClient(_client);
        Dispatch = new DispatchClient(_client);
        Messages = new MessagesClient(_client);
        TrailerAssignments = new TrailerAssignmentsClient(_client);
        Trips = new TripsClient(_client);
        Machines = new MachinesClient(_client);
        Sensors = new SensorsClient(_client);
        Webhooks = new WebhooksClient(_client);
        Auth = new AuthClient(_client);
    }

    public AddressesClient Addresses { get; }

    public AlertsClient Alerts { get; }

    public LocationAndSpeedClient LocationAndSpeed { get; }

    public AttributesClient Attributes { get; }

    public BetaClient Beta { get; }

    public CoachingClient Coaching { get; }

    public ContactsClient Contacts { get; }

    public MaintenanceClient Maintenance { get; }

    public DriverQrCodesClient DriverQrCodes { get; }

    public CarrierProposedAssignmentsClient CarrierProposedAssignments { get; }

    public DocumentsClient Documents { get; }

    public DriverVehicleAssignmentsClient DriverVehicleAssignments { get; }

    public DriversClient Drivers { get; }

    public TachographEuOnlyClient TachographEuOnly { get; }

    public LegacyClient Legacy { get; }

    public EquipmentClient Equipment { get; }

    public HoursOfServiceClient HoursOfService { get; }

    public FuelAndEnergyClient FuelAndEnergy { get; }

    public IftaClient Ifta { get; }

    public IdlingClient Idling { get; }

    public RoutesClient Routes { get; }

    public SafetyClient Safety { get; }

    public SettingsClient Settings { get; }

    public TrailersClient Trailers { get; }

    public VehiclesClient Vehicles { get; }

    public VehicleLocationsClient VehicleLocations { get; }

    public VehicleStatsClient VehicleStats { get; }

    public GatewaysClient Gateways { get; }

    public IndustrialClient Industrial { get; }

    public LiveSharingLinksClient LiveSharingLinks { get; }

    public OrganizationInfoClient OrganizationInfo { get; }

    public PreviewClient Preview { get; }

    public TagsClient Tags { get; }

    public UsersClient Users { get; }

    public AssetsClient Assets { get; }

    public DispatchClient Dispatch { get; }

    public MessagesClient Messages { get; }

    public TrailerAssignmentsClient TrailerAssignments { get; }

    public TripsClient Trips { get; }

    public MachinesClient Machines { get; }

    public SensorsClient Sensors { get; }

    public WebhooksClient Webhooks { get; }

    public AuthClient Auth { get; }
}
