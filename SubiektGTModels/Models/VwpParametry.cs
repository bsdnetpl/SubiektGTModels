using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwpParametry
{
    public int? PtId { get; set; }

    public string? PtOpis { get; set; }

    public bool? PtIndywidualizowalny { get; set; }

    public string? PtNazwa { get; set; }

    public int? PtProgramy { get; set; }

    public string? PtProgId { get; set; }

    public int? PtProgIdCtx { get; set; }

    public int? PtAppObjId { get; set; }

    public int? PeId { get; set; }
}
