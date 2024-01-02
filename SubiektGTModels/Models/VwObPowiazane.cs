using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwObPowiazane
{
    public int OpId { get; set; }

    public int OpTypWskazywanego { get; set; }

    public string OpOpisTypuWskazywanego { get; set; } = null!;

    public int OpIdWskazywanego { get; set; }

    public string? OpOpisObiektu { get; set; }

    public int OpTypOb { get; set; }

    public string OpOpisTypuOb { get; set; } = null!;

    public int OpIdOb { get; set; }

    public string? OpOpisOb { get; set; }

    public string OpOpisPowiazania { get; set; } = null!;

    public int? OpPrywatne { get; set; }

    public int? OpOpiekun { get; set; }

    public int? OpKontoEmail { get; set; }

    public int? OpEmailUsuniety { get; set; }

    public int? OpPrywatneWskazywanego { get; set; }

    public int? OpOpiekunWskazywanego { get; set; }

    public int? OpKontoEmailWskazywanego { get; set; }

    public int? OpEmailUsunietyWskazywanego { get; set; }
}
