using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwObPowiazaneGridSymbolTr
{
    public int? OpId { get; set; }

    public int OpKierunek { get; set; }

    public int OpIdObiektu { get; set; }

    public string? OpOpisObiektu { get; set; }

    public int OpTypObiektu { get; set; }

    public string OpOpisTypu { get; set; } = null!;

    public int OpIdIdent { get; set; }

    public int OpTypIdent { get; set; }

    public string OpOpisPowiazania { get; set; } = null!;

    public int? OpPrywatne { get; set; }

    public int? OpEmailUsuniety { get; set; }

    public int? EmDeleteStat { get; set; }
}
