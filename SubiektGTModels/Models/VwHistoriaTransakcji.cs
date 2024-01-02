using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwHistoriaTransakcji
{
    public int? Syntheticid { get; set; }

    public int? IdNadrz { get; set; }

    public int IdPodrz { get; set; }

    public int TypOb { get; set; }

    public DateTime Data { get; set; }

    public string OpisOb { get; set; } = null!;

    public string? Operator { get; set; }

    public string? Opis { get; set; }

    public int Usuniety { get; set; }
}
