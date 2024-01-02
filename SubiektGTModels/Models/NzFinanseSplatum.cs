using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzFinanseSplatum
{
    public int NzsId { get; set; }

    public int? NzsIdSplaty { get; set; }

    public int NzsIdDlugu { get; set; }

    public decimal NzsWartoscWaluta { get; set; }

    public string NzsIdWaluty { get; set; } = null!;

    public DateTime NzsData { get; set; }

    public int NzsTyp { get; set; }

    public int? NzsIdKompensaty { get; set; }

    public bool NzsAuto { get; set; }

    public bool NzsPrzedplata { get; set; }

    public decimal NzsWartoscWalutaDlugu { get; set; }

    public string NzsIdWalutyDlugu { get; set; } = null!;

    public decimal? NzsWartoscSplatyPln { get; set; }

    public decimal? NzsWartoscDluguPln { get; set; }

    public bool NzsWylaczBadanieZgodnosci { get; set; }

    public bool NzsMetodaKasowa { get; set; }

    public int NzsRodzaj { get; set; }

    public bool NzsAutoPrzeliczanie { get; set; }

    public int NzsStatusKsieg { get; set; }

    public bool NzsBrakKontroliSumy { get; set; }

    public int NzsIdTransakcjiVat { get; set; }

    public int? NzsIdKategorii { get; set; }

    public decimal NzsVatdluguWaluta { get; set; }

    public decimal NzsVatsplatyWaluta { get; set; }

    public bool NzsVatRozliczanyPrzezUslugobiorce { get; set; }

    public virtual ICollection<NzFinanseSplataVat> NzFinanseSplataVats { get; set; } = new List<NzFinanseSplataVat>();

    public virtual NzFinanse NzsIdDluguNavigation { get; set; } = null!;

    public virtual SlKategorium? NzsIdKategoriiNavigation { get; set; }

    public virtual NzFinanse? NzsIdSplatyNavigation { get; set; }
}
