using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DksParametrCesja
{
    public int FpcId { get; set; }

    public int FpcTypDok { get; set; }

    public int FpcParamEwidId { get; set; }

    public int FpcFormatNumId { get; set; }

    public int? FpcIdKategorii { get; set; }

    public int FpcTypKursu { get; set; }

    public int FpcDataKursu { get; set; }

    public bool FpcOstatniKurs { get; set; }

    public bool FpcNrRozZdok { get; set; }

    public virtual SlFormatNumeracji FpcFormatNum { get; set; } = null!;

    public virtual ParEwid FpcParamEwid { get; set; } = null!;
}
