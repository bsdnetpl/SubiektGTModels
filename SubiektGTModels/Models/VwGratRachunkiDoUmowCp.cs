using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratRachunkiDoUmowCp
{
    public int Ident { get; set; }

    public int StatusRach { get; set; }

    public int StatusSkladki { get; set; }

    public int StatusZaliczki { get; set; }

    public string? Pracownik { get; set; }

    public DateTime Data { get; set; }

    public string Numer { get; set; } = null!;

    public decimal Wartosc { get; set; }

    public decimal BruttoDuze { get; set; }

    public decimal Netto { get; set; }

    public decimal DoWyplaty { get; set; }

    public decimal ZusPracownik { get; set; }

    public decimal ZusPracodawca { get; set; }

    public decimal ZaliczkaPodatek { get; set; }

    public decimal? Zdrowotne { get; set; }

    public string? NumerUmowy { get; set; }

    public int? RodzajUmowyId { get; set; }

    public string? RodzajUmowy { get; set; }

    public string? NaCzas { get; set; }

    public DateTime? DataOd { get; set; }

    public DateTime? DataDo { get; set; }

    public DateTime? DataRozwiazania { get; set; }

    public int? IdKategoria { get; set; }

    public string? KategoriaNazwa { get; set; }

    public int? PrId { get; set; }

    public int? PrIdGrupy { get; set; }

    public string? Nip { get; set; }

    public string? Pesel { get; set; }

    public decimal PodstawaOpodatkowania { get; set; }

    public decimal PodstawaEmerRent { get; set; }

    public int RuFlagi { get; set; }

    public string RuOpis { get; set; } = null!;

    public bool Zatwierdzony { get; set; }

    public int RuBylPrzelew { get; set; }

    public int RuBylKw { get; set; }

    public int RuBylWydruk { get; set; }

    public bool RuRyczalt { get; set; }

    public decimal RuPodatekProcent { get; set; }

    public int RuRokPrzychodu { get; set; }

    public decimal? Ppksuma { get; set; }

    public decimal? Ppkpracownik { get; set; }

    public decimal? Ppkpracodawca { get; set; }

    public decimal RuPrzelew { get; set; }

    public decimal RuDoReki { get; set; }

    public int RuStatusImportuPpk { get; set; }
}
