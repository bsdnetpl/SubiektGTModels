using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrkartaWynagrodzenRachunki
{
    public int IdPracownika { get; set; }

    public DateTime UmowaOd { get; set; }

    public DateTime Data { get; set; }

    public decimal BruttoDuze { get; set; }

    public decimal PrzychodyBrutto { get; set; }

    public decimal KosztUzyskania { get; set; }

    public decimal Dochod { get; set; }

    public decimal? ObZalNaPodDoch { get; set; }

    public decimal UbezpieczenieZdrowotneOdliczane { get; set; }

    public decimal UbezpieczenieZdrowotneNieodliczane { get; set; }

    public decimal NalZalNaPodDoch { get; set; }

    public DateTime DataZaliczki { get; set; }

    public decimal? UbEmerytalne { get; set; }

    public decimal UbRentowe { get; set; }

    public decimal UbChorobowe { get; set; }

    public DateTime Miesiac { get; set; }

    public bool Ryczalt { get; set; }
}
