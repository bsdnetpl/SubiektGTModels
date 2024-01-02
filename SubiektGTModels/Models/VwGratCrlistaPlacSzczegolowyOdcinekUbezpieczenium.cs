using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacSzczegolowyOdcinekUbezpieczenium
{
    public int IdWyplaty { get; set; }

    public decimal ZusPrac { get; set; }

    public decimal ZusFirma { get; set; }

    public decimal Zus { get; set; }

    public decimal ZusZasilki { get; set; }

    public decimal ZusRazem { get; set; }

    public decimal ObciazeniePracodawcy { get; set; }
}
