using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseRozrachunek
{
    public int NzId { get; set; }

    public DateTime NzDataPowstania { get; set; }

    public DateTime? NzTerminPlatnosci { get; set; }

    public int NzTyp { get; set; }

    public decimal NzWartoscPierwotna { get; set; }

    public decimal NzWartoscPierwotnaWaluta { get; set; }

    public decimal NzWartosc { get; set; }

    public decimal NzWartoscWaluta { get; set; }

    public string NzIdWaluty { get; set; } = null!;

    public decimal NzKurs { get; set; }

    public int NzRodzajKursu { get; set; }

    public string? NzTytulem { get; set; }

    public int? NzTypOdsetek { get; set; }

    public decimal? NzStopaOdsetek { get; set; }

    public DateTime? NzDataOstatniejSplaty { get; set; }

    public int? NzIdDokumentAuto { get; set; }

    public int? NzIdAdresu { get; set; }

    public int? NzIdHistoriiAdresu { get; set; }

    public int? NzIdObiektu { get; set; }

    public int NzTypObiektu { get; set; }

    public int NzStatus { get; set; }

    public string? NzPrb { get; set; }

    public int? NzIdKategorii { get; set; }

    public int NzIdWystawil { get; set; }

    public bool NzPrzeniesiony { get; set; }

    public bool NzNota { get; set; }

    public int? NzPodtyp { get; set; }

    public int? NzZrodlo { get; set; }

    public int? NzProgram { get; set; }

    public int? NzIdRozrachunku { get; set; }

    public bool NzPowiazanie { get; set; }

    public bool NzKorekta { get; set; }

    public string? NzTransakcja { get; set; }
}
