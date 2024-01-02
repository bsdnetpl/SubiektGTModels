using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacSzczegolowyOdcinekPodatek
{
    public int IdWyplaty { get; set; }

    public decimal BruttoDuze { get; set; }

    public decimal BruttoMale { get; set; }

    public decimal ZaliczkaNaPodatek { get; set; }

    public decimal Netto { get; set; }

    public decimal NeRazem { get; set; }

    public decimal PracownikOtrzymuje { get; set; }
}
