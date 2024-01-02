using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlStawkaZaszeregowanium
{
    public int SzaId { get; set; }

    public int? SzaKategoria { get; set; }

    public string? SzaNazwa { get; set; }

    public decimal? SzaMiesiecznaMin { get; set; }

    public decimal? SzaMiesiecznaMax { get; set; }

    public decimal? SzaDziennaMin { get; set; }

    public decimal? SzaDziennaMax { get; set; }

    public decimal? SzaGodzinowaMin { get; set; }

    public decimal? SzaGodzinowaMax { get; set; }

    public virtual ICollection<SlStanowisko> SlStanowiskoStnKategoriaMaxNavigations { get; set; } = new List<SlStanowisko>();

    public virtual ICollection<SlStanowisko> SlStanowiskoStnKategoriaMinNavigations { get; set; } = new List<SlStanowisko>();
}
