using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzCesjaParametrTp
{
    public int CptpId { get; set; }

    public int CptpTypDok { get; set; }

    public int? CptpTerminalId { get; set; }

    public string? CptpKomputer { get; set; }

    public int? CptpParamEwidId { get; set; }

    public int CptpDefiniowalnyId { get; set; }

    public virtual ParEwid? CptpParamEwid { get; set; }
}
