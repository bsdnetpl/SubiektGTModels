using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseBankRazem
{
    public int NzfId { get; set; }

    public int? NzfIdHistoriiAdresu { get; set; }

    public DateTime NzfData { get; set; }

    public int NzfTyp { get; set; }

    public string? NzfTytulem { get; set; }

    public int NzfStatus { get; set; }

    public bool NzfWyslanaHb { get; set; }

    public bool NzfWydrukowana { get; set; }

    public string? NzfNumerWyciagu { get; set; }

    public string? NzfWystawil { get; set; }

    public decimal NzfKurs { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public int? NzfImport { get; set; }

    public string? NzfOpis { get; set; }

    public int? NzfIdRachunku { get; set; }

    public decimal? Wplata { get; set; }

    public decimal? Wyplata { get; set; }

    public int? NzfIdObiektu { get; set; }

    public int NzfTypObiektu { get; set; }

    public decimal? WplataWaluta { get; set; }

    public decimal? WyplataWaluta { get; set; }

    public int? NzfIdKategorii { get; set; }

    public int? NzfIdDokumentAuto { get; set; }

    public int? NzfIdRachObiektHist { get; set; }

    public int? NzfProgram { get; set; }

    public int? NzfZrodlo { get; set; }

    public bool NzfPowiazanie { get; set; }

    public int? PrId { get; set; }

    public string? NzfNumerPelny { get; set; }

    public bool? JestNaWyciagu { get; set; }

    public string? NrWyciagu { get; set; }

    public int PowiazanieZtransakcja { get; set; }

    public bool NzfZaliczka { get; set; }

    public int NzfPodtypPp { get; set; }

    public string? NzfNrFaktury { get; set; }

    public decimal NzfVatpierwotny { get; set; }

    public decimal? NzfKwotaRachunkuVat { get; set; }

    public decimal NzfSplataWaluta { get; set; }

    public int? NzfIdRachObiekt { get; set; }

    public int? NzfIdSesjiKasowej { get; set; }

    public bool? KhrNaBialejLiscie { get; set; }

    public DateTime? KhrDataWeryfikacji { get; set; }

    public int? DeId { get; set; }
}
