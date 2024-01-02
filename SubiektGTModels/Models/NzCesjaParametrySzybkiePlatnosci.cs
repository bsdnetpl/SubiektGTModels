using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzCesjaParametrySzybkiePlatnosci
{
    public int CpspId { get; set; }

    public int CpspFormatNumId { get; set; }

    public bool CpspNrRozZdok { get; set; }

    public int? CpspIdKategorii { get; set; }

    public int CpspParamEwidId { get; set; }

    public virtual SlFormatNumeracji CpspFormatNum { get; set; } = null!;

    public virtual ParEwid CpspParamEwid { get; set; } = null!;
}
