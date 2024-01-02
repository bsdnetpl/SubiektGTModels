using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrskladnikPlacowyDefinicje
{
    public int IdSpdef { get; set; }

    public int IdSp { get; set; }

    public int Typ { get; set; }

    public string Opis { get; set; } = null!;

    public DateTime? DataOd { get; set; }

    public DateTime? DataDo { get; set; }
}
