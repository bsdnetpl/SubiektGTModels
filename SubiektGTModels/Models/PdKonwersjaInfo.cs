using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdKonwersjaInfo
{
    public int KiId { get; set; }

    public string? KiWersjaDo { get; set; }

    public DateTime? KiDataKonwersji { get; set; }

    public string? KiWersjaProgramu { get; set; }

    public int? KiKonwersjaOdlaczanieId { get; set; }

    public virtual PdKonwersjaOdlaczanie? KiKonwersjaOdlaczanie { get; set; }
}
