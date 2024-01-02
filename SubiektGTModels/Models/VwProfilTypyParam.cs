using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwProfilTypyParam
{
    public int PtId { get; set; }

    public string PtOpis { get; set; } = null!;

    public bool PtIndywidualizowalny { get; set; }

    public string PtNazwa { get; set; } = null!;

    public int PtProgramy { get; set; }

    public string PtProgId { get; set; } = null!;

    public int? PtProgIdCtx { get; set; }

    public int PtAppObjId { get; set; }

    public bool PtUkryte { get; set; }

    public int PtStatusNowosci { get; set; }
}
