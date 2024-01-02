using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyWzorzec
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

    public bool WzwWidoczny { get; set; }

    public int WzwStatusNowosci { get; set; }

    public virtual ICollection<DokStatusWydruku> DokStatusWydrukus { get; set; } = new List<DokStatusWydruku>();

    public virtual ICollection<WyDrukarkaDomyslna> WyDrukarkaDomyslnas { get; set; } = new List<WyDrukarkaDomyslna>();

    public virtual ICollection<WyWzDomyslny> WyWzDomyslnies { get; set; } = new List<WyWzDomyslny>();

    public virtual WyNaglowek? WzwNaglowekRaportu { get; set; }

    public virtual WyNaglowek? WzwNaglowekStrony { get; set; }

    public virtual WyNaglowek? WzwStopkaRaportu { get; set; }

    public virtual WyNaglowek? WzwStopkaStrony { get; set; }

    public virtual WyTyp WzwTypNavigation { get; set; } = null!;

    public virtual ICollection<PdUzytkownik> PfIdUzytkownikas { get; set; } = new List<PdUzytkownik>();
}
