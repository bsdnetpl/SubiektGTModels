using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwImpRachunek
{
    public int RuId { get; set; }

    public int RuIdUmowy { get; set; }

    public int? RuIdKategorii { get; set; }

    public DateTime RuDataWystawienia { get; set; }

    public DateTime RuDataSkladek { get; set; }

    public DateTime? RuDataZaliczek { get; set; }

    public int RuStatusImportuRachunku { get; set; }

    public int RuStatusImportuSkladek { get; set; }

    public int? RuStatusImportuZaliczek { get; set; }

    public string RuNumer { get; set; } = null!;

    public int RuIdPracownika { get; set; }

    public decimal RuKwotaRachunku { get; set; }

    public decimal RuZusfirma { get; set; }

    public decimal RuUbezpZdrowotne { get; set; }

    public decimal RuUbezpZdrowotne2 { get; set; }

    public decimal RuZusrazem { get; set; }

    public decimal RuZaliczkaNaPodatek { get; set; }

    public decimal RuFp { get; set; }

    public decimal RuFgsp { get; set; }

    public int RuStatusImportuPpk { get; set; }

    public DateTime RuDataWplatyPpk { get; set; }

    public decimal? WplataPracodawcyPpkrazem { get; set; }
}
