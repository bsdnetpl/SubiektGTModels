using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrzObnizkaPodatku
{
    public int ObpId { get; set; }

    public DateTime ObpDataZapisu { get; set; }

    public int ObpIdWspolnika { get; set; }

    public decimal ObpKwota { get; set; }

    public int ObpIdRodzajuObnizki { get; set; }

    public int ObpSposobOdliczania { get; set; }

    public DateTime ObpDataOd { get; set; }

    public DateTime ObpDataDo { get; set; }

    public string ObpOpis { get; set; } = null!;

    public int? ObpTypObiektu { get; set; }

    public int? ObpIdObiektu { get; set; }

    public virtual SlRodzajObnizki ObpIdRodzajuObnizkiNavigation { get; set; } = null!;

    public virtual PdWspolnik ObpIdWspolnikaNavigation { get; set; } = null!;
}
