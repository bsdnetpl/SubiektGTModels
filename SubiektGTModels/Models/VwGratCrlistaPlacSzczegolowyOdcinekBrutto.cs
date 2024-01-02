using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacSzczegolowyOdcinekBrutto
{
    public int IdWyplaty { get; set; }

    public decimal BruttoDuze { get; set; }

    public decimal BruttoMale { get; set; }

    public decimal ZusPrac { get; set; }

    public decimal ObnizeniePodstawyZus { get; set; }

    public decimal InneZwolnienia { get; set; }
}
