using Samsara.Net.Addresses;
using Samsara.Net.Alerts;
using Samsara.Net.Assets;
using Samsara.Net.Attributes;
using Samsara.Net.Auth;
using Samsara.Net.Beta;
using Samsara.Net.Cameras;
using Samsara.Net.CarrierProposedAssignments;
using Samsara.Net.Coaching;
using Samsara.Net.Contacts;
using Samsara.Net.Core;
using Samsara.Net.Defects;
using Samsara.Net.DefectTypes;
using Samsara.Net.Devices;
using Samsara.Net.Documents;
using Samsara.Net.DocumentTypes;
using Samsara.Net.Drivers;
using Samsara.Net.DriverTrailerAssignments;
using Samsara.Net.DriverVehicleAssignments;
using Samsara.Net.Dvirs;
using Samsara.Net.Equipment;
using Samsara.Net.FormSubmissions;
using Samsara.Net.FuelPurchases;
using Samsara.Net.Gateways;
using Samsara.Net.Hos;
using Samsara.Net.HoursOfService;
using Samsara.Net.Ifta;
using Samsara.Net.Inputs;
using Samsara.Net.Issues;
using Samsara.Net.Legacy;
using Samsara.Net.LiveShares;
using Samsara.Net.Maintenance;
using Samsara.Net.Me;
using Samsara.Net.Reports;
using Samsara.Net.Routes;
using Samsara.Net.SafetyEvents;
using Samsara.Net.Settings;
using Samsara.Net.SpeedingIntervals;
using Samsara.Net.Tags;
using Samsara.Net.Trailers;
using Samsara.Net.TrainingAssignments;
using Samsara.Net.TrainingCourses;
using Samsara.Net.Trips;
using Samsara.Net.UserRoles;
using Samsara.Net.Users;
using Samsara.Net.Vehicles;
using Samsara.Net.Webhooks;

namespace Samsara.Net;

public partial class SamsaraClient
{
    private readonly RawClient _client;

    public SamsaraClient(string? token = null, ClientOptions? clientOptions = null)
    {
        token ??= GetFromEnvironmentOrThrow(
            "SAMSARA_API_KEY",
            "Please pass in token or set the environment variable SAMSARA_API_KEY."
        );
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {token}" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Samsara.Net" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Samsara.Net/0.0.19" },
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
        Assets = new AssetsClient(_client);
        Inputs = new InputsClient(_client);
        Attributes = new AttributesClient(_client);
        Contacts = new ContactsClient(_client);
        DefectTypes = new DefectTypesClient(_client);
        Defects = new DefectsClient(_client);
        Devices = new DevicesClient(_client);
        DriverTrailerAssignments = new DriverTrailerAssignmentsClient(_client);
        Dvirs = new DvirsClient(_client);
        CarrierProposedAssignments = new CarrierProposedAssignmentsClient(_client);
        DocumentTypes = new DocumentTypesClient(_client);
        Documents = new DocumentsClient(_client);
        DriverVehicleAssignments = new DriverVehicleAssignmentsClient(_client);
        Drivers = new DriversClient(_client);
        Equipment = new EquipmentClient(_client);
        Hos = new HosClient(_client);
        HoursOfService = new HoursOfServiceClient(_client);
        Routes = new RoutesClient(_client);
        SafetyEvents = new SafetyEventsClient(_client);
        Trailers = new TrailersClient(_client);
        Vehicles = new VehiclesClient(_client);
        Legacy = new LegacyClient(_client);
        FormSubmissions = new FormSubmissionsClient(_client);
        FuelPurchases = new FuelPurchasesClient(_client);
        Gateways = new GatewaysClient(_client);
        Beta = new BetaClient(_client);
        Issues = new IssuesClient(_client);
        LiveShares = new LiveSharesClient(_client);
        Me = new MeClient(_client);
        SpeedingIntervals = new SpeedingIntervalsClient(_client);
        Tags = new TagsClient(_client);
        TrainingAssignments = new TrainingAssignmentsClient(_client);
        TrainingCourses = new TrainingCoursesClient(_client);
        Trips = new TripsClient(_client);
        UserRoles = new UserRolesClient(_client);
        Users = new UsersClient(_client);
        Webhooks = new WebhooksClient(_client);
        Auth = new AuthClient(_client);
        Alerts = new AlertsClient(_client);
        Cameras = new CamerasClient(_client);
        Coaching = new CoachingClient(_client);
        Ifta = new IftaClient(_client);
        Maintenance = new MaintenanceClient(_client);
        Reports = new ReportsClient(_client);
        Settings = new SettingsClient(_client);
    }

    public AddressesClient Addresses { get; }

    public AssetsClient Assets { get; }

    public InputsClient Inputs { get; }

    public AttributesClient Attributes { get; }

    public ContactsClient Contacts { get; }

    public DefectTypesClient DefectTypes { get; }

    public DefectsClient Defects { get; }

    public DevicesClient Devices { get; }

    public DriverTrailerAssignmentsClient DriverTrailerAssignments { get; }

    public DvirsClient Dvirs { get; }

    public CarrierProposedAssignmentsClient CarrierProposedAssignments { get; }

    public DocumentTypesClient DocumentTypes { get; }

    public DocumentsClient Documents { get; }

    public DriverVehicleAssignmentsClient DriverVehicleAssignments { get; }

    public DriversClient Drivers { get; }

    public EquipmentClient Equipment { get; }

    public HosClient Hos { get; }

    public HoursOfServiceClient HoursOfService { get; }

    public RoutesClient Routes { get; }

    public SafetyEventsClient SafetyEvents { get; }

    public TrailersClient Trailers { get; }

    public VehiclesClient Vehicles { get; }

    public LegacyClient Legacy { get; }

    public FormSubmissionsClient FormSubmissions { get; }

    public FuelPurchasesClient FuelPurchases { get; }

    public GatewaysClient Gateways { get; }

    public BetaClient Beta { get; }

    public IssuesClient Issues { get; }

    public LiveSharesClient LiveShares { get; }

    public MeClient Me { get; }

    public SpeedingIntervalsClient SpeedingIntervals { get; }

    public TagsClient Tags { get; }

    public TrainingAssignmentsClient TrainingAssignments { get; }

    public TrainingCoursesClient TrainingCourses { get; }

    public TripsClient Trips { get; }

    public UserRolesClient UserRoles { get; }

    public UsersClient Users { get; }

    public WebhooksClient Webhooks { get; }

    public AuthClient Auth { get; }

    public AlertsClient Alerts { get; }

    public CamerasClient Cameras { get; }

    public CoachingClient Coaching { get; }

    public IftaClient Ifta { get; }

    public MaintenanceClient Maintenance { get; }

    public ReportsClient Reports { get; }

    public SettingsClient Settings { get; }

    private static string GetFromEnvironmentOrThrow(string env, string message)
    {
        return Environment.GetEnvironmentVariable(env) ?? throw new Exception(message);
    }
}
