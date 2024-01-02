using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratPotraceniaKomornicze
{
    public int KpId { get; set; }

    public int KpIdPracownika { get; set; }

    public int KpIdSkladnika { get; set; }

    public int? StatusRozliczenia { get; set; }

    public string KpNazwa { get; set; } = null!;

    public string? Pracownik { get; set; }

    public string? Rodzaj { get; set; }

    public string KpSygnaturaSprawy { get; set; } = null!;

    public int KpRodzaj { get; set; }

    public int KpSposobPotracania { get; set; }

    public decimal KpProcentWynagrodzeniaPotracany { get; set; }

    public decimal KpSumaPotracenia { get; set; }

    public DateTime KpDataOd { get; set; }

    public DateTime? KpDataDo { get; set; }

    public decimal KpKwotaPotraceniaMiesiecznego { get; set; }

    public decimal KpProcentOchronyWynagrodzenia { get; set; }

    public int KpCzestotliwoscPotracania { get; set; }

    public int KpPriorytetPotracenia { get; set; }

    public DateTime? KpZawieszenieDataOd { get; set; }

    public DateTime? KpZawieszenieDataDo { get; set; }

    public bool KpCzyNaSwiadectwiePracy { get; set; }

    public string KpKomornik { get; set; } = null!;

    public string? Skladnik { get; set; }

    public decimal? SumKwotaWyliczona { get; set; }

    public decimal? SumKwotaPotracona { get; set; }

    public decimal? Saldo { get; set; }

    public string? SposobPotracania { get; set; }

    public int Zawieszenie { get; set; }

    public decimal WartoscPotraceniaJednorazowoNext { get; set; }

    public int? FlgNumer { get; set; }

    public DateTime? FlwCzasOstatniejZmiany { get; set; }

    public string? UzIdentyfikator { get; set; }

    public string? FlwKomentarz { get; set; }

    public int? FlwIdFlagi { get; set; }

    public string? FlgText { get; set; }

    public int? FlgId { get; set; }

    public DateTime? DataDoWirtualna { get; set; }

    public int? IdUmowaOpraceOstatnia { get; set; }

    public int? PrId { get; set; }

    public int? PrIdGrupy { get; set; }
}
