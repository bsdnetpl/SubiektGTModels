using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZbiorczaPozycjaEx
{
    public int ObId { get; set; }

    public int? ObDoId { get; set; }

    public short ObZnak { get; set; }

    public int? ObStatus { get; set; }

    public int? ObDokHanId { get; set; }

    public int? ObDokMagId { get; set; }

    public int? ObTowId { get; set; }

    public int ObTowRodzaj { get; set; }

    public decimal? ObIloscMagPdst { get; set; }

    public decimal? ObWartMag { get; set; }

    public decimal? ObWartNetto { get; set; }

    public decimal? ObWartVat { get; set; }

    public decimal? ObWartBrutto { get; set; }

    public int DokId { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }

    public int? DokMagId { get; set; }

    public int? DokDoDokId { get; set; }

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

    public int DokStatus { get; set; }

    public int? DokPersonelId { get; set; }

    public string DokWystawil { get; set; } = null!;

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

    public int DokRodzajOperacjiVat { get; set; }

    public string? ObJm { get; set; }

    public decimal? ObIloscMag { get; set; }
}
