using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwPolaWlasneZadanie
{
    public int ZdId { get; set; }

    public int? ZdIdZrodla { get; set; }

    public int ZdRodzaj { get; set; }

    public int? ZdPodtyp { get; set; }

    public int? ZdPersonel { get; set; }

    public bool ZdCalyDzien { get; set; }

    public DateTime ZdPoczatek { get; set; }

    public DateTime? ZdKoniec { get; set; }

    public DateTime? ZdPoczatekZcyklu { get; set; }

    public string? ZdLokalizacja { get; set; }

    public string ZdTemat { get; set; } = null!;

    public int ZdPriorytet { get; set; }

    public string ZdKolor { get; set; } = null!;

    public int ZdInterwal { get; set; }

    public int ZdCoIle { get; set; }

    public bool ZdRobocze { get; set; }

    public int ZdDniTygodnia { get; set; }

    public int ZdDzienMiesiaca { get; set; }

    public bool? ZdDefinicjaZlozona { get; set; }

    public int ZdDzienPorzadek { get; set; }

    public int ZdDzienRodzaj { get; set; }

    public int ZdMiesiac { get; set; }

    public int ZdRodzajPowtorzen { get; set; }

    public int ZdIlePowtorzen { get; set; }

    public DateTime? ZdKoniecPowtorzen { get; set; }

    public int? ZdStatus { get; set; }

    public int? ZdRezultat { get; set; }

    public bool? ZdPokazujWkalendarzu { get; set; }

    public int? ZdKierunek { get; set; }

    public int? ZdKiedyPrzypomnienie { get; set; }

    public string? ZdOpisPowtorzen { get; set; }

    public bool ZdBezCzasu { get; set; }

    public DateTime? ZdNastepnePrzypomnienie { get; set; }

    public bool ZdPrzypomniane { get; set; }

    public string ZdUwagi { get; set; } = null!;

    public string ZdUczestnicy { get; set; } = null!;

    public bool ZdPrywatne { get; set; }

    public int? ZdTransakcja { get; set; }

    public int ZdFormaDzialaniaWindykacyjnego { get; set; }

    public int ZdKlasa { get; set; }

    public int? ZdNotaOdsetkowa { get; set; }

    public int? ZdWezwanieDoZaplaty { get; set; }

    public string? ZdDluznik { get; set; }

    public string? ZdLokalizacjaMapy { get; set; }

    public DateTime? ZdWystapienieDoPrzypomnienia { get; set; }

    public int? ZdDokumentId { get; set; }

    public string? ZdDokumentUwagi { get; set; }

    public bool ZdDokumentPrzepisuj { get; set; }

    public int? ZdWystawionyDokId { get; set; }

    public int? ZdZlecenieId { get; set; }

    public int ZdLiczbaUczestnikowBezPersonelu { get; set; }

    public int ZdLiczbaUczestnikowWszystkich { get; set; }

    public bool ZdKotwicz { get; set; }

    public bool ZdNotatkaZakonczona { get; set; }

    public int? PwdId { get; set; }

    public int? PwdTypObiektu { get; set; }

    public int? PwdIdObiektu { get; set; }

    public int? PwdIdPozycji { get; set; }

    public DateTime? PwdData01 { get; set; }

    public DateTime? PwdData02 { get; set; }

    public DateTime? PwdData03 { get; set; }

    public DateTime? PwdData04 { get; set; }

    public DateTime? PwdData05 { get; set; }

    public DateTime? PwdData06 { get; set; }

    public DateTime? PwdData07 { get; set; }

    public DateTime? PwdData08 { get; set; }

    public DateTime? PwdData09 { get; set; }

    public DateTime? PwdData10 { get; set; }

    public int? PwdLiczba01 { get; set; }

    public int? PwdLiczba02 { get; set; }

    public int? PwdLiczba03 { get; set; }

    public int? PwdLiczba04 { get; set; }

    public int? PwdLiczba05 { get; set; }

    public int? PwdLiczba06 { get; set; }

    public int? PwdLiczba07 { get; set; }

    public int? PwdLiczba08 { get; set; }

    public int? PwdLiczba09 { get; set; }

    public int? PwdLiczba10 { get; set; }

    public string? PwdTekst01 { get; set; }

    public string? PwdTekst02 { get; set; }

    public string? PwdTekst03 { get; set; }

    public string? PwdTekst04 { get; set; }

    public string? PwdTekst05 { get; set; }

    public string? PwdTekst06 { get; set; }

    public string? PwdTekst07 { get; set; }

    public string? PwdTekst08 { get; set; }

    public string? PwdTekst09 { get; set; }

    public string? PwdTekst10 { get; set; }

    public decimal? PwdKwota01 { get; set; }

    public decimal? PwdKwota02 { get; set; }

    public decimal? PwdKwota03 { get; set; }

    public decimal? PwdKwota04 { get; set; }

    public decimal? PwdKwota05 { get; set; }

    public decimal? PwdKwota06 { get; set; }

    public decimal? PwdKwota07 { get; set; }

    public decimal? PwdKwota08 { get; set; }

    public decimal? PwdKwota09 { get; set; }

    public decimal? PwdKwota10 { get; set; }

    public int? PwdFk01 { get; set; }

    public int? PwdFk02 { get; set; }

    public int? PwdFk03 { get; set; }

    public int? PwdFk04 { get; set; }

    public int? PwdFk05 { get; set; }

    public int? PwdFk06 { get; set; }

    public int? PwdFk07 { get; set; }

    public int? PwdFk08 { get; set; }

    public int? PwdFk09 { get; set; }

    public int? PwdFk10 { get; set; }

    public bool? PwdFlaga01 { get; set; }

    public bool? PwdFlaga02 { get; set; }

    public bool? PwdFlaga03 { get; set; }

    public bool? PwdFlaga04 { get; set; }

    public bool? PwdFlaga05 { get; set; }

    public bool? PwdFlaga06 { get; set; }

    public bool? PwdFlaga07 { get; set; }

    public bool? PwdFlaga08 { get; set; }

    public bool? PwdFlaga09 { get; set; }

    public bool? PwdFlaga10 { get; set; }
}
