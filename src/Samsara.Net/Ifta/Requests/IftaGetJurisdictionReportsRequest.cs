using Samsara.Net.Core;

namespace Samsara.Net.Ifta;

public record IftaGetJurisdictionReportsRequest
{
    /// <summary>
    /// The year of the requested IFTA report summary. Must be provided with a month or quarter param. Example: `year=2021`
    /// </summary>
    public required int Year { get; set; }

    /// <summary>
    /// The month of the requested IFTA report summary. Can not be provided with the quarter param. Example: `month=January`  Valid values: `January`, `February`, `March`, `April`, `May`, `June`, `July`, `August`, `September`, `October`, `November`, `December`
    /// </summary>
    public IftaGetJurisdictionReportsRequestMonth? Month { get; set; }

    /// <summary>
    /// The quarter of the requested IFTA report summary. Can not be provided with the month param. Q1: January, February, March. Q2: April, May, June. Q3: July, August, September. Q4: October, November, December. Example: `quarter=Q1`  Valid values: `Q1`, `Q2`, `Q3`, `Q4`
    /// </summary>
    public IftaGetJurisdictionReportsRequestQuarter? Quarter { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of jurisdictions. Example: `jurisdictions=GA`
    /// </summary>
    public string? Jurisdictions { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of IFTA fuel types. Example: `fuelType=Diesel`  Valid values: `Unspecified`, `A55`, `Biodiesel`, `CompressedNaturalGas`, `Diesel`, `E85`, `Electricity`, `Ethanol`, `Gasohol`, `Gasoline`, `Hydrogen`, `LiquifiedNaturalGas`, `M85`, `Methanol`, `Propane`, `Other`
    /// </summary>
    public IftaGetJurisdictionReportsRequestFuelType? FuelType { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of vehicle IDs and externalIds. Example: `vehicleIds=1234,5678,samsara.vin:1HGBH41JXMN109186`
    /// </summary>
    public string? VehicleIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of tag IDs. Example: `tagIds=1234,5678`
    /// </summary>
    public string? TagIds { get; set; }

    /// <summary>
    /// A filter on the data based on this comma-separated list of parent tag IDs, for use by orgs with tag hierarchies. Specifying a parent tag will implicitly include all descendent tags of the parent tag. Example: `parentTagIds=345,678`
    /// </summary>
    public string? ParentTagIds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
