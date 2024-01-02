using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwCesje
{
    public int NzcId { get; set; }

    public int NzcRodzaj { get; set; }

    public int NzcTyp { get; set; }

    public string NzcNumer { get; set; } = null!;

    public int NzcIdSplata { get; set; }

    public int NzcIdCesyjny { get; set; }

    public int NzcStatusKsieg { get; set; }

    public int TypSplata { get; set; }

    public int TypCesyjny { get; set; }

    public DateTime NzfData { get; set; }

    public DateTime? NzfTerminPlatnosci { get; set; }

    public decimal? Wartosc { get; set; }

    public decimal? WartoscWaluta { get; set; }

    public string IdWaluty { get; set; } = null!;

    public string? NzfWystawil { get; set; }

    public int? NzfIdKategorii { get; set; }

    public string? NzfTytulem { get; set; }

    public int? CesjonariuszIdAdrh { get; set; }

    public int? DluznikIdAdrh { get; set; }

    public int CesjonariuszTyp { get; set; }

    public int DluznikTyp { get; set; }

    public string? DowodKsiegowy { get; set; }

    public int? NzfTermPlatStatus { get; set; }

    public string? NzfTermPlatTransId { get; set; }

    public int? NzfIdKarta { get; set; }

    public int? SplataRozliczenie { get; set; }
}
