using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseKasaRazem
{
    public int NzfId { get; set; }

    public int? NzfIdKasy { get; set; }

    public DateTime NzfData { get; set; }

    public int? NzfNumer { get; set; }

    public string? NzfNumerPelny { get; set; }

    public string? NzfTytulem { get; set; }

    public int NzfTyp { get; set; }

    public int? NzfIdKategorii { get; set; }

    public int? NzfImport { get; set; }

    public string? NzfWystawil { get; set; }

    public string? NzfOdebral { get; set; }

    public int? NzfIdDokumentAuto { get; set; }

    public string? NzfOpis { get; set; }

    public int NzfStatus { get; set; }

    public int? NzfIdHistoriiAdresu { get; set; }

    public bool NzfGenerujTytulem { get; set; }

    public decimal? Wplata { get; set; }

    public int? NzfIdObiektu { get; set; }

    public int NzfTypObiektu { get; set; }

    public decimal? Wyplata { get; set; }

    public int? NzfProgram { get; set; }

    public int? NzfZrodlo { get; set; }

    public bool NzfPowiazanie { get; set; }

    public decimal? WplataWaluta { get; set; }

    public decimal? WyplataWaluta { get; set; }

    public string NzfIdWaluty { get; set; } = null!;

    public decimal NzfKurs { get; set; }

    public int? PrId { get; set; }

    public bool? JestNaRaporcie { get; set; }

    public string? NrRaportu { get; set; }

    public bool NzfZaliczka { get; set; }

    public bool NzfTransfer { get; set; }

    public int? NzfIdSesjiKasowej { get; set; }

    public bool? Oczekujacy { get; set; }

    public int NzfStatusIkona { get; set; }
}
