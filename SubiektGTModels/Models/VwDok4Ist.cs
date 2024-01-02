using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDok4Ist
{
    public int DokId { get; set; }

    public int DokTyp { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public int? DokPlatnikId { get; set; }

    public DateTime DokDataWyst { get; set; }

    public DateTime DokDataMag { get; set; }

    public int? DokDoDokId { get; set; }

    public int? ObTowId { get; set; }

    public decimal? ObIloscMag { get; set; }

    public string? ObJm { get; set; }

    public decimal? ObWartNetto { get; set; }

    public int ObZnak { get; set; }

    public int? DokPlatnikAdreshId { get; set; }

    public int? DokKodRodzajuTransakcji { get; set; }

    public bool DokJestRuchMag { get; set; }

    public int DokStatus { get; set; }

    public int? DokStatusEx { get; set; }

    public int ObId { get; set; }

    public int? DokNr { get; set; }

    public int DokRodzajOperacjiVat { get; set; }

    public int? DokIdPanstwaKonsumenta { get; set; }
}
