using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokParametrTp
{
    public int DktpTyp { get; set; }

    public int DktpPodtyp { get; set; }

    public int? DktpTerminalId { get; set; }

    public string? DktpKomputer { get; set; }

    public int? DktpParamEwidId { get; set; }

    public int DktpDefiniowalnyId { get; set; }
}
