using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwZstWydWgKhnt
{
    public int DokId { get; set; }

    public int? DokKatId { get; set; }

    public int? DokPlatnikId { get; set; }

    public int? DokPlatnikAdreshId { get; set; }

    public int? DokOdbiorcaId { get; set; }

    public int? DokOdbiorcaAdreshId { get; set; }

    public int? DokMagId { get; set; }

    public int DokStatus { get; set; }

    public DateTime DokDataWyst { get; set; }

    public string DokWystawil { get; set; } = null!;

    public int DokRodzajOperacjiVat { get; set; }

    public int? TypDlugi { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }

    public int ObId { get; set; }

    public int? ObTowId { get; set; }

    public int ObTowRodzaj { get; set; }

    public string? ObJm { get; set; }

    public decimal? ObIloscMag { get; set; }

    public decimal? ObWartMag { get; set; }

    public decimal? ObWartNetto { get; set; }

    public decimal? ObWartBrutto { get; set; }

    public short ObZnak { get; set; }
}
