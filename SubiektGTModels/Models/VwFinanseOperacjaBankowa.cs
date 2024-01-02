using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwFinanseOperacjaBankowa
{
    public int OpId { get; set; }

    public int? OpIdRachunku { get; set; }

    public int? OpIdRachunkuHist { get; set; }

    public decimal OpWartosc { get; set; }

    public decimal OpWartoscWaluta { get; set; }

    public decimal OpSplata { get; set; }

    public decimal OpSplataWaluta { get; set; }

    public string OpIdWaluty { get; set; } = null!;

    public decimal OpKurs { get; set; }

    public int OpRodzajKursu { get; set; }

    public DateTime OpData { get; set; }

    public int OpTyp { get; set; }

    public string? OpTytulem { get; set; }

    public int OpStatus { get; set; }

    public int? OpIdKategorii { get; set; }

    public string? OpNumerWyciagu { get; set; }

    public DateTime? OpDataUzgodnienia { get; set; }

    public int? OpImport { get; set; }

    public string? OpWystawil { get; set; }

    public int OpIdWystawil { get; set; }

    public bool OpWyslanaHb { get; set; }

    public bool OpWydrukowana { get; set; }

    public bool OpZaliczka { get; set; }

    public bool OpGenerujTytulem { get; set; }

    public bool OpObslugaRachunku { get; set; }

    public bool OpGotowkowa { get; set; }

    public int? OpIdDokumentAuto { get; set; }

    public int? OpIdAdresu { get; set; }

    public int? OpIdHistoriiAdresu { get; set; }

    public int? OpIdRachObiekt { get; set; }

    public int? OpIdRachObiektHist { get; set; }

    public int OpTypObiektu { get; set; }

    public int? OpIdObiektu { get; set; }

    public string OpTypPrzelewu { get; set; } = null!;

    public string? OpZuspodIdentyfikator { get; set; }

    public string? OpZuspodTypIdentyfikatora { get; set; }

    public string? OpZustypWplaty { get; set; }

    public string? OpZusdeklaracja { get; set; }

    public string? OpZusnrDeklaracji { get; set; }

    public string? OpPodSymbol { get; set; }

    public string? OpPodIdentyfikacjaZobowiazania { get; set; }

    public string? OpPodOkres { get; set; }

    public bool OpTransfer { get; set; }

    public string? OpZusnrDecyzji { get; set; }

    public DateTime? OpDataKursu { get; set; }

    public int? OpIdBanku { get; set; }

    public int OpLiczbaJednostek { get; set; }

    public int? OpPodtyp { get; set; }

    public string? OpOpis { get; set; }

    public decimal OpVatpierwotnyWaluta { get; set; }
}
