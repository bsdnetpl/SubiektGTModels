using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacSzczegolowyOdcinek
{
    public int IdWyplaty { get; set; }

    public string LpTytul { get; set; } = null!;

    public string LpNumer { get; set; } = null!;

    public DateTime LpMiesiac { get; set; }

    public DateTime LpDataWyplaty { get; set; }

    public string Umowa { get; set; } = null!;

    public string Pracownik { get; set; } = null!;

    public int IdPracownika { get; set; }

    public string? UpWymiar { get; set; }

    public string PrNip { get; set; } = null!;

    public string PrPesel { get; set; } = null!;

    public string PrEmail { get; set; } = null!;
}
