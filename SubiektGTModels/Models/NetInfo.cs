using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NetInfo
{
    public int NeiId { get; set; }

    public DateTime? NeiOstatniePolaczenie { get; set; }

    public string NeiWersjaProgramuNr { get; set; } = null!;

    public string NeiWersjaProgramuNazwa { get; set; } = null!;

    public string NeiWersjaProgramuPlatnaNr { get; set; } = null!;

    public string NeiWersjaProgramuPlatnaNazwa { get; set; } = null!;

    public DateTime? NeiKursyData { get; set; }

    public DateTime? NeiKursyUdane { get; set; }

    public string NeiWersjaParametrow { get; set; } = null!;

    public string? NeiLic { get; set; }

    public int NeiIdOstatniejWiadomosci { get; set; }

    public bool NeiZnanyNip { get; set; }

    public DateTime? NeiOstatnieUdanePolaczenie { get; set; }

    public string NeiOstatnieUdaneKomputer { get; set; } = null!;

    public DateTime? NeiOstatnieNieudanePolaczenie { get; set; }

    public string NeiOstatnieNieudaneKomputer { get; set; } = null!;

    public string? NeiLicInne { get; set; }

    public byte[]? NeiExtReportData { get; set; }

    public byte[]? NeiAccountingOfficeRegistrationData { get; set; }
}
