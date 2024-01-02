using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacSzczegolowyOdcinekNetto
{
    public int IdWyplaty { get; set; }

    public decimal BruttoMale { get; set; }

    public decimal KosztUzyskania { get; set; }

    public decimal PodstawaOpodatkowania { get; set; }

    public decimal Podatek { get; set; }

    public decimal Odliczenia { get; set; }

    public decimal UbezpieczenieZdrowotne { get; set; }

    public decimal ZaliczkaObliczona { get; set; }

    public decimal ZaliczkaNaPodatek { get; set; }

    public decimal Netto { get; set; }

    public decimal PodstUbZdrowotn { get; set; }

    public decimal? PpkPracodawcy { get; set; }

    public decimal? PpkPracownika { get; set; }

    public decimal UlgaDlaKlasySredniej { get; set; }

    public decimal InneZwolnienia { get; set; }
}
