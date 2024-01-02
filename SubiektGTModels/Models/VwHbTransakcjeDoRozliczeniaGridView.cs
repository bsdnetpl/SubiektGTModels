using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwHbTransakcjeDoRozliczeniaGridView
{
    public int HbStatus { get; set; }

    public int WieleRozrachunkow { get; set; }

    public int HbIdTransakcji { get; set; }

    public int HbIdNaglowekTr { get; set; }

    public int? HbIdOperacjiBankowej { get; set; }

    public string HbNumerRachunku { get; set; } = null!;

    public string? HbBilansOtwarciaWaluta { get; set; }

    public string? HbOznaczenie { get; set; }

    public string? HbWaluta { get; set; }

    public int HbStatus1 { get; set; }

    public int TypOperacji { get; set; }

    public DateTime? HbDataUtworzeniaWyciagu { get; set; }

    public DateTime? HbDataKsiegowania { get; set; }

    public string? HbKontrahent { get; set; }

    public string? HbRachKontrahent { get; set; }

    public decimal? HbKwota { get; set; }

    public string? Waluta { get; set; }

    public decimal? HbKurs { get; set; }

    public decimal? HbKwotaWaluty { get; set; }

    public DateTime? HbDataWaluty { get; set; }

    public string? HbNumerWyciagu { get; set; }

    public string? HbKodTranzakcji { get; set; }

    public string? HbOpisTranzakcji { get; set; }

    public string? HbTytul { get; set; }

    public bool HbSprawdzonoSkojarzanie { get; set; }

    public int? RbIdObiektu { get; set; }

    public int? RbTypObiektu { get; set; }

    public string? HbIdentyfikatorMp { get; set; }

    public string? HbPelnyNumerMp { get; set; }

    public bool RbWirtualny { get; set; }
}
