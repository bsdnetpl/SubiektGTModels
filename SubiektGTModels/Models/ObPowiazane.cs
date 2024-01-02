using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ObPowiazane
{
    public int OpId { get; set; }

    public int OpTypWskazywanego { get; set; }

    public string OpOpisTypuWskazywanego { get; set; } = null!;

    public int OpIdWskazywanego { get; set; }

    public string OpOpisObiektu { get; set; } = null!;

    public int OpTypOb { get; set; }

    public string OpOpisTypuOb { get; set; } = null!;

    public int OpIdOb { get; set; }

    public string OpOpisOb { get; set; } = null!;

    public string OpOpisPowiazania { get; set; } = null!;
}
