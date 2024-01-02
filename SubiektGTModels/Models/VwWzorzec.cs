using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwWzorzec
{
    public int WzwId { get; set; }

    public int WzwTyp { get; set; }

    public int WzwZrodlo { get; set; }

    public string WzwNazwa { get; set; } = null!;

    public int WzwTypPliku { get; set; }

    public int WzwIloscKopii { get; set; }

    public int? WzwNaglowekRaportuId { get; set; }

    public int? WzwNaglowekStronyId { get; set; }

    public int? WzwStopkaStronyId { get; set; }

    public int? WzwStopkaRaportuId { get; set; }

    public bool WzwUkladStrony { get; set; }

    public bool WzwZablokowany { get; set; }

    public int WzwJezyk { get; set; }

    public string WzwWersja { get; set; } = null!;

    public bool WzwWysuwajStrone { get; set; }

    public int WzwStatusNowosci { get; set; }
}
