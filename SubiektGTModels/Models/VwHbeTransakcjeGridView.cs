using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwHbeTransakcjeGridView
{
    public int HbIdTransakcji { get; set; }

    public int HbIdNaglowekTr { get; set; }

    public int? HbIdOperacjiBankowej { get; set; }

    public string HbNumerRachunku { get; set; } = null!;

    public string? HbBilansOtwarciaWaluta { get; set; }

    public string? HbOznaczenie { get; set; }

    public string? HbWaluta { get; set; }

    public int HbStatus { get; set; }

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

    public int Wygenerowana { get; set; }

    public int Pominieta { get; set; }

    public string? HbTytul { get; set; }

    public string? HbNrFaktury { get; set; }

    public bool HbSprawdzonoSkojarzanie { get; set; }

    public string? HbIdentyfikatorMp { get; set; }

    public string? HbPelnyNumerMp { get; set; }

    public int PowiazanieOpWb { get; set; }

    public string? WbNr { get; set; }

    public DateTime? WbData { get; set; }

    public int? WbId { get; set; }

    public int? HbIdRachunku { get; set; }

    public int HbZrodlo { get; set; }

    public int? HbtoId { get; set; }

    public int PowiazaneTrOczk { get; set; }

    public int? HbtoProgram { get; set; }
}
