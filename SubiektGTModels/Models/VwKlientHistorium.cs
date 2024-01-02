using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwKlientHistorium
{
    public int? Syntheticid { get; set; }

    public DateTime Data { get; set; }

    public string Obiekt { get; set; } = null!;

    public string? Zdarzenie { get; set; }

    public int Lot { get; set; }

    public int Id { get; set; }

    public int? Idklienta { get; set; }

    public int? Idfirmy { get; set; }

    public int? Idpersonelu { get; set; }
}
