using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IwRozbicie
{
    public int IwrId { get; set; }

    public int IwrDoPozId { get; set; }

    public decimal? IwrIloscRozchod { get; set; }

    public decimal? IwrIloscPrzychod { get; set; }

    public decimal? IwrCenaNetto { get; set; }

    public decimal? IwrWartosc { get; set; }

    public string? IwrKodDostawy { get; set; }

    public string? IwrOpisPozycji { get; set; }

    public int? IwrKategoriaId { get; set; }

    public int? IwrDysp { get; set; }

    public bool? IwrRozbitaAuto { get; set; }

    public DateTime? IwrTerminWaznosci { get; set; }
}
