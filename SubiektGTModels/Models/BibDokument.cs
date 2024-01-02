using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class BibDokument
{
    public int BibId { get; set; }

    public int BibTypObiektu { get; set; }

    public int BibIdObiektu { get; set; }

    public string BibNazwa { get; set; } = null!;

    public string BibOpis { get; set; } = null!;

    public string BibTyp { get; set; } = null!;

    public int BibIdKategorii { get; set; }

    public bool BibZablokowany { get; set; }

    public DateTime BibDataModyfikacji { get; set; }

    public int BibZmodyfikowal { get; set; }

    public DateTime BibDataDodania { get; set; }

    public int BibDodal { get; set; }

    public decimal BibRozmiar { get; set; }

    public bool BibEpodpis { get; set; }

    public int? BibEpodpisPowiazany { get; set; }

    public string? BibSciezkaDoPliku { get; set; }

    public string? BibStanowisko { get; set; }

    public int? BibPodkategoria { get; set; }

    public int? BibIdKary { get; set; }

    public bool BibEAkta { get; set; }

    public bool BibWyeksportowany { get; set; }

    public virtual PrMotywacja? BibIdKaryNavigation { get; set; }
}
