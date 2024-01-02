using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwHbTransakcjeDoSkojarzenium
{
    public int HbIdTransakcji { get; set; }

    public int HbIdNaglowekTr { get; set; }

    public int HbStatus { get; set; }

    public int Widoczna { get; set; }

    public string HbNumerRachunku { get; set; } = null!;

    public string? HbOznaczenie { get; set; }

    public string? HbBilansOtwarciaWaluta { get; set; }

    public string? HbWaluta { get; set; }

    public int TypOperacji { get; set; }

    public int HbPodtypPp { get; set; }

    public DateTime? HbDataUtworzeniaWyciagu { get; set; }

    public DateTime? HbDataKsiegowania { get; set; }

    public string? HbKontrahent { get; set; }

    public string? HbRachKontrahent { get; set; }

    public decimal? HbKwota { get; set; }

    public decimal HbVat { get; set; }

    public string? Waluta { get; set; }

    public decimal? HbKurs { get; set; }

    public decimal? HbKwotaWaluty { get; set; }

    public DateTime? HbDataWaluty { get; set; }

    public string? HbNumerWyciagu { get; set; }

    public string? HbKodTranzakcji { get; set; }

    public string? HbOpisTranzakcji { get; set; }

    public string? HbTytul { get; set; }

    public string? HbNrFaktury { get; set; }

    public string HbZnormalizowanyNumerRachunku { get; set; } = null!;
}
