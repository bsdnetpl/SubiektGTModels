using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbTransakcja
{
    public int HbIdNaglowekTr { get; set; }

    public int HbIdTransakcji { get; set; }

    public DateTime? HbDataWaluty { get; set; }

    public DateTime? HbDataKsiegowania { get; set; }

    public string? HbOznaczenie { get; set; }

    public decimal? HbKwota { get; set; }

    public string? HbKodTranzakcji { get; set; }

    public string? HbOpisTranzakcji { get; set; }

    public string? HbKontrahent { get; set; }

    public string? HbRachKontrahent { get; set; }

    public string? HbWaluta { get; set; }

    public decimal? HbKwotaWaluty { get; set; }

    public decimal? HbKurs { get; set; }

    public int? HbIdOperacjiBankowej { get; set; }

    public bool HbSprawdzonoSkojarzanie { get; set; }

    public int HbStatus { get; set; }

    public string? HbTytul { get; set; }

    public string? HbIdentyfikatorMp { get; set; }

    public string? HbPelnyNumerMp { get; set; }

    public int HbZrodlo { get; set; }

    public string HbTnr { get; set; } = null!;

    public int? HbIdTranOczek { get; set; }

    public int HbPodtypPp { get; set; }

    public decimal HbVat { get; set; }

    public string? HbNrFaktury { get; set; }

    public virtual HbNaglowekIstopka HbIdNaglowekTrNavigation { get; set; } = null!;

    public virtual HbPowiazanieTransakcji? HbPowiazanieTransakcji { get; set; }
}
