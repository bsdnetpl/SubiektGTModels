using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PojPojazd
{
    public int PojId { get; set; }

    public string PojMarka { get; set; } = null!;

    public string PojNrRej { get; set; } = null!;

    public int? PojIdWlasciciela { get; set; }

    public string PojWlasciciel { get; set; } = null!;

    public int PojTyp { get; set; }

    public int? PojUzywanyJako { get; set; }

    public bool PojUzywany { get; set; }

    public int PojMalyPojazd { get; set; }

    public bool PojPelneOdliczenieVat { get; set; }

    public DateTime? PojDataRozpoczecia { get; set; }

    public decimal PojStanLicznika { get; set; }

    public DateTime? PojDataKoncaEwidencji { get; set; }

    public string? PojNrAnalityka { get; set; }

    public int PojPrzypadekSzczegolnyPit { get; set; }

    public virtual ICollection<PojEksploatacja> PojEksploatacjas { get; set; } = new List<PojEksploatacja>();

    public virtual ICollection<PojKosztyEksploatacjiWpi> PojKosztyEksploatacjiWpis { get; set; } = new List<PojKosztyEksploatacjiWpi>();

    public virtual ICollection<PojKsiegowanie> PojKsiegowanies { get; set; } = new List<PojKsiegowanie>();
}
