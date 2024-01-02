using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrPozycja
{
    public int DkoId { get; set; }

    public int DkoIdRoku { get; set; }

    public DateTime DkoDataDekretacji { get; set; }

    public int DkoStatus { get; set; }

    public int? DkoIdDokumentu { get; set; }

    public string DkoKonto { get; set; } = null!;

    public decimal? DkoKwotaWn { get; set; }

    public decimal? DkoKwotaWnWaluta { get; set; }

    public decimal? DkoKwotaMa { get; set; }

    public decimal? DkoKwotaMaWaluta { get; set; }

    public string DkoWaluta { get; set; } = null!;

    public decimal DkoKurs { get; set; }

    public int DkoLiczbaJednostek { get; set; }

    public int? DkoRodzajKursu { get; set; }

    public DateTime? DkoDataKursu { get; set; }

    public int? DkoIdBanku { get; set; }

    public string DkoOpis { get; set; } = null!;

    public int DkoGrupa { get; set; }

    public int DkoLpWiersza { get; set; }

    public int DkoTypWiersza { get; set; }

    public bool DkoKorektaZaokraglen { get; set; }

    public int? DkoNrWdzienniku { get; set; }

    public int? DkoIdStawkiVat { get; set; }

    public int? DkoIdKategorii { get; set; }

    public virtual SlWalutaBank? DkoIdBankuNavigation { get; set; }

    public virtual DkrDokument? DkoIdDokumentuNavigation { get; set; }

    public virtual PdRokObrotowy DkoIdRokuNavigation { get; set; } = null!;

    public virtual SlStawkaVat? DkoIdStawkiVatNavigation { get; set; }

    public virtual SlWalutum DkoWalutaNavigation { get; set; } = null!;

    public virtual ICollection<DkrBilansOtwarciaDostawy> DkrBilansOtwarciaDostawies { get; set; } = new List<DkrBilansOtwarciaDostawy>();

    public virtual DkrPozycjaWydatekNaPojazd? DkrPozycjaWydatekNaPojazd { get; set; }

    public virtual ICollection<DkrRoznicaKursowa> DkrRoznicaKursowaDkrkIdPozycjiNavigations { get; set; } = new List<DkrRoznicaKursowa>();

    public virtual ICollection<DkrRoznicaKursowa> DkrRoznicaKursowaDkrkIdPozycjiWyplatyNavigations { get; set; } = new List<DkrRoznicaKursowa>();

    public virtual ICollection<NzRozDekret> NzRozDekrets { get; set; } = new List<NzRozDekret>();
}
