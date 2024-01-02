using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzCesjaParametr
{
    public int CpaId { get; set; }

    public int CpaFormatNumId { get; set; }

    public bool CpaDokHandlAuto { get; set; }

    public bool CpaDokHandlNpk { get; set; }

    public int CpaParamEwidId { get; set; }

    public bool? CpaTerminalPlatniczy { get; set; }

    public bool? CpaTerminalPlatniczyAuto { get; set; }

    public int? CpaIdKategorii { get; set; }

    public bool CpaNrRozZdok { get; set; }

    public bool CpaDrukujPoZapisie { get; set; }

    public virtual SlFormatNumeracji CpaFormatNum { get; set; } = null!;
}
