using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaDzialStanowisko
{
    public int UdzId { get; set; }

    public int UdzIdUmowy { get; set; }

    public DateTime UdzDataOd { get; set; }

    public DateTime? UdzDataDo { get; set; }

    public int? UdzIdDzialu { get; set; }

    public int? UdzIdStanowiska { get; set; }

    public bool UdzCzyNaliczacFep { get; set; }

    public int? UdzIdKoduPracyWszczChar { get; set; }

    public int? UdzIdKategorii { get; set; }

    public bool UdzPracaNauczycielska { get; set; }

    public int? UdzTypPracyNauczycielskiej { get; set; }

    public bool UdzSzkolnictwoSpecjalne { get; set; }

    public int? UdzWymiarZajec { get; set; }

    public virtual SlDzial? UdzIdDzialuNavigation { get; set; }

    public virtual SlPracaSzczegolnyCharakter? UdzIdKoduPracyWszczCharNavigation { get; set; }

    public virtual SlStanowisko? UdzIdStanowiskaNavigation { get; set; }

    public virtual PlbUmowa UdzIdUmowyNavigation { get; set; } = null!;
}
