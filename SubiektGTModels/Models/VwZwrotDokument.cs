using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZwrotDokument
{
    public int DokId { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }

    public int? DokMagId { get; set; }

    public int? DokNr { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public string DokNrPelnyOryg { get; set; } = null!;

    public DateTime DokDataMag { get; set; }

    public DateTime? DokDataOtrzym { get; set; }

    public DateTime DokDataWyst { get; set; }

    public int? DokPlatnikAdreshId { get; set; }

    public int? DokOdbiorcaId { get; set; }

    public DateTime? DokPlatTermin { get; set; }

    public decimal? DokKwGotowka { get; set; }

    public decimal? DokKwKarta { get; set; }

    public decimal? DokKwDoZaplaty { get; set; }

    public decimal? DokKwKredyt { get; set; }

    public int? DokKatId { get; set; }

    public int? DokPlatnikId { get; set; }

    public decimal? DokWartUsNetto { get; set; }

    public decimal? DokWartUsBrutto { get; set; }

    public decimal? DokWartTwNetto { get; set; }

    public decimal? DokWartTwBrutto { get; set; }

    public decimal? DokWartOpZwr { get; set; }

    public decimal? DokWartOpWyd { get; set; }

    public decimal? DokWartMag { get; set; }

    public decimal? DokWartNetto { get; set; }

    public decimal? DokWartVat { get; set; }

    public decimal? DokWartBrutto { get; set; }

    public decimal? DokKwWartosc { get; set; }

    public int DokStatus { get; set; }

    public int? DokStatusEx { get; set; }

    public int? DokPersonelId { get; set; }

    public int? DokDoDokId { get; set; }

    public int DokRodzajOperacjiVat { get; set; }

    public int DokStatusFiskal { get; set; }

    public int? DokOdbiorcaAdreshId { get; set; }

    public string? DokWaluta { get; set; }

    public decimal DokWalutaKurs { get; set; }

    public bool? DokVatMarza { get; set; }

    public DateTime? DokDataZakonczenia { get; set; }

    public bool DokMetodaKasowa { get; set; }

    public bool DokDokumentFiskalnyDlaPodatnikaVat { get; set; }

    public bool DokCesjaPlatnikOdbiorca { get; set; }

    public decimal DokWartOplRecykl { get; set; }

    public bool DokMechanizmPodzielonejPlatnosci { get; set; }

    public DateTime? DokDataUjeciaKorekty { get; set; }

    public bool DokVatRozliczanyPrzezUslugobiorce { get; set; }
}
