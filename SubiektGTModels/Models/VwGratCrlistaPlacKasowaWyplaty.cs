using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacKasowaWyplaty
{
    public int IdListyPlac { get; set; }

    public int IdWyplaty { get; set; }

    public string Pracownik { get; set; } = null!;

    public decimal KwotaWKasie { get; set; }
}
