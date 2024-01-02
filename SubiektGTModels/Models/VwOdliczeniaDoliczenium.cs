using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwOdliczeniaDoliczenium
{
    public int OdId { get; set; }

    public int OdRodzaj { get; set; }

    public int OdIdWspolnika { get; set; }

    public DateTime OdDataZapisu { get; set; }

    public decimal OdKwota { get; set; }

    public int OdSposobOdliczania { get; set; }

    public int? OdIdRodzajuOdliczenia { get; set; }

    public DateTime OdDataOd { get; set; }

    public DateTime OdDataDo { get; set; }

    public string OdOpis { get; set; } = null!;

    public decimal? KwotaOdliczenia { get; set; }

    public decimal? KwotaDoliczenia { get; set; }

    public int? OdTypObiektu { get; set; }

    public int? OdIdObiektu { get; set; }
}
