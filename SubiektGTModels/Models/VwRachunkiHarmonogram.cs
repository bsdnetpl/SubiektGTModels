using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwRachunkiHarmonogram
{
    public int IdHarm { get; set; }

    public string Nazwa { get; set; } = null!;

    public int CzyJednorazowy { get; set; }

    public string Numer { get; set; } = null!;

    public string Pracownik { get; set; } = null!;

    public string? Zatrudnienie { get; set; }

    public DateTime? DataJednorazowa { get; set; }

    public DateTime OkresOd { get; set; }

    public DateTime? OkresDo { get; set; }

    public int CyklTygodniowy { get; set; }

    public int? RodzajPrzychodu { get; set; }

    public int? SzablonRachunku { get; set; }

    public int? DzienMiesiaca { get; set; }

    public int? DzienTygodnia { get; set; }

    public decimal KwotaRachunku { get; set; }

    public decimal Potracenia { get; set; }

    public decimal ZasilekRodzinny { get; set; }

    public decimal DodatekRodzinny { get; set; }

    public decimal Pielegnacyjny { get; set; }

    public decimal Rehabilitacyjne { get; set; }

    public bool Akordy { get; set; }

    public bool Prowizje { get; set; }

    public bool Ecp { get; set; }

    public int? EcpMiesiac { get; set; }

    public decimal DodatkiNieopodatkowane { get; set; }
}
