using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PoParametryOnline
{
    public int PoId { get; set; }

    public string? PoLiniaProduktow { get; set; }

    public int? PoProdukt { get; set; }

    public string PoZakres { get; set; } = null!;

    public string PoKlucz { get; set; } = null!;

    public string PoWersja { get; set; } = null!;

    public string? PoWartosc { get; set; }

    public DateTime PoOstatniaAktualizacja { get; set; }
}
