using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PosParam
{
    public int PposId { get; set; }

    public int PposTyp { get; set; }

    public int PposPodtyp { get; set; }

    public int? PposDefiniowalnyId { get; set; }

    public int PposDomyslnyWidok { get; set; }

    public int PposDomyslnaAkcjaTw { get; set; }

    public int PposParamEwidId { get; set; }

    public bool? PposKlawiaturaSystemowa { get; set; }

    public int PposBrakTowaruAkcja { get; set; }

    public bool PposPrzyciskiPlatnosci { get; set; }

    public virtual ParEwid PposParamEwid { get; set; } = null!;
}
