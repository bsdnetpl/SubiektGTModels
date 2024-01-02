using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DwDokument
{
    public int DwewId { get; set; }

    public string DwewNrDokumentu { get; set; } = null!;

    public int DwewTypObiektu { get; set; }

    public int? DwewIdObiektu { get; set; }

    public DateTime DwewData { get; set; }

    public int? DwewIdkategorii { get; set; }

    public decimal DwewWartosc { get; set; }

    public string DwewUwagi { get; set; } = null!;

    public string DwewWystawil { get; set; } = null!;

    public string DwewMiejsceWyst { get; set; } = null!;

    public int? DwewTypDokImport { get; set; }

    public int? DwewIdDokImport { get; set; }

    public decimal DwewWartoscPrzychod { get; set; }

    public int DwewTyp { get; set; }

    public string DwewOpis { get; set; } = null!;

    public virtual ICollection<DwPozycja> DwPozycjas { get; set; } = new List<DwPozycja>();

    public virtual SlKategorium? DwewIdkategoriiNavigation { get; set; }
}
