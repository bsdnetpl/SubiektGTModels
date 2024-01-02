using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KorKorektaKosztow
{
    public int KknId { get; set; }

    public int KknTyp { get; set; }

    public int KknPodtyp { get; set; }

    public int KknMagId { get; set; }

    public int KknNr { get; set; }

    public string? KknNrRoz { get; set; }

    public string KknNrPelny { get; set; } = null!;

    public string KknMscWyst { get; set; } = null!;

    public DateTime KknDataWyst { get; set; }

    public DateTime KknDataOd { get; set; }

    public DateTime KknDataDo { get; set; }

    public decimal? KknWartKkhz { get; set; }

    public decimal? KknWartKkhs { get; set; }

    public decimal? KknWartKkmp { get; set; }

    public decimal? KknWartKkmw { get; set; }

    public decimal? KknWartKkmwop { get; set; }

    public decimal? KknWartKkmwob { get; set; }

    public decimal? KknWartWzhan { get; set; }

    public decimal? KknWartWzmag { get; set; }

    public decimal? KknWartRw { get; set; }

    public decimal? KknWartPz { get; set; }

    public decimal? KknWartMmp { get; set; }

    public decimal? KknWartMmw { get; set; }

    public string KknWystawil { get; set; } = null!;

    public int KknPersonelId { get; set; }

    public int KknStatus { get; set; }

    public int KknStatusKsieg { get; set; }

    public int? KknKatId { get; set; }

    public string KknUwagi { get; set; } = null!;

    public string KknTytul { get; set; } = null!;

    public string KknPodtytul { get; set; } = null!;

    public virtual SlKategorium? KknKat { get; set; }

    public virtual ICollection<KorPozycja> KorPozycjas { get; set; } = new List<KorPozycja>();
}
