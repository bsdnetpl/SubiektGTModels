using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwBibliotekaDokumentow
{
    public int BibId { get; set; }

    public string? BibTypObiektuTxt { get; set; }

    public int BibTypObiektu { get; set; }

    public int BibIdObiektu { get; set; }

    public string BibNazwa { get; set; } = null!;

    public string BibOpis { get; set; } = null!;

    public string BibTyp { get; set; } = null!;

    public int BibIdKategorii { get; set; }

    public DateTime BibDataModyfikacji { get; set; }

    public int BibZmodyfikowal { get; set; }

    public DateTime BibDataDodania { get; set; }

    public int BibDodal { get; set; }

    public bool BibZablokowany { get; set; }

    public decimal BibRozmiar { get; set; }

    public string? KdNazwa { get; set; }

    public string? UzZmodNazwiskoImie { get; set; }

    public string? UzUtwNazwiskoImie { get; set; }

    public string? BibNazwaObiektu { get; set; }

    public bool BibEpodpis { get; set; }

    public string? BibPowiazanyNazwa { get; set; }

    public string? BibSciezkaDoPliku { get; set; }

    public string BibJestWbazie { get; set; } = null!;

    public string? BibStanowisko { get; set; }

    public bool BibWyeksportowany { get; set; }

    public bool BibEAkta { get; set; }

    public int? BibPodkategoria { get; set; }

    public string? PmoNazwa { get; set; }
}
