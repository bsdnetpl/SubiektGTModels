using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdWspolnikPodatek
{
    public int PwrId { get; set; }

    public int PwrIdWspolnika { get; set; }

    public int? PwrRokOd { get; set; }

    public int PwrWartosc { get; set; }

    public int PwrPlatnosc { get; set; }

    public bool PwrCzyNaliczacUlgeDlaKlasySredniejWzaliczce { get; set; }

    public bool PwrZaliczkaUproszczona { get; set; }

    public bool PwrZaliczkaOdliczajZdr { get; set; }

    public virtual PdWspolnik PwrIdWspolnikaNavigation { get; set; } = null!;
}
