using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacSzczegolowyOdcinekDoWyplaty
{
    public int IdWyplaty { get; set; }

    public decimal Netto { get; set; }

    public decimal UbezpieczenieZdrowotne2 { get; set; }

    public decimal PracownikOtrzymuje { get; set; }

    public decimal Przelew { get; set; }

    public decimal DoReki { get; set; }
}
