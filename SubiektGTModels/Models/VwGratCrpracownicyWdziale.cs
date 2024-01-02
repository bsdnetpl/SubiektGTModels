using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrpracownicyWdziale
{
    public int PracownikId { get; set; }

    public int? DzialId { get; set; }

    public int? GrupaPracownikaId { get; set; }

    public string PracownikImie { get; set; } = null!;

    public string PracownikImie2 { get; set; } = null!;

    public string PracownikNazwisko { get; set; } = null!;

    public string? DzialNazwa { get; set; }

    public string UmowaPracyNumer { get; set; } = null!;

    public DateTime? UmowaPracyWDzialeDataOd { get; set; }

    public DateTime? UmowaPracyWDzialeDataDo { get; set; }
}
