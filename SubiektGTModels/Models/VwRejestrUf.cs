using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwRejestrUf
{
    public int UtrId { get; set; }

    public int UtrIdKonfiguracja { get; set; }

    public int UtrStatus { get; set; }

    public DateTime UtrDataCzas { get; set; }

    public string UkoNazwa { get; set; } = null!;

    public string Operacja { get; set; } = null!;

    public string UtrStatusOpis { get; set; } = null!;

    public string Uzytkownik { get; set; } = null!;

    public string UtrKomputer { get; set; } = null!;

    public int? DokNr { get; set; }

    public string? DokNrPelny { get; set; }
}
