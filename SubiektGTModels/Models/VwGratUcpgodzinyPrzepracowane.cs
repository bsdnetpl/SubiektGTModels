using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratUcpgodzinyPrzepracowane
{
    public int Id { get; set; }

    public int? Rok { get; set; }

    public int? Miesiac { get; set; }

    public DateTime UmowaDataOd { get; set; }

    public DateTime? UmowaDataDo { get; set; }

    public string Imie { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string NrUmowy { get; set; } = null!;

    public int? LiczbaRachunkow { get; set; }

    public decimal? SumaRachunkow { get; set; }

    public int? SumaGodzin { get; set; }

    public decimal SredniaStawkaGodz { get; set; }
}
