using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PojKosztyEksploatacji
{
    public int PojkeId { get; set; }

    public int? PojkeIdKategorii { get; set; }

    public string PojkeNrDok { get; set; } = null!;

    public DateTime PojkeData { get; set; }

    public int PojkeStatus { get; set; }

    public int PojkeJako { get; set; }

    public decimal PojkeRachunkiMc { get; set; }

    public decimal PojkeRachunkiRos { get; set; }

    public decimal PojkePrzejazdyMc { get; set; }

    public decimal PojkePrzejazdyRos { get; set; }

    public decimal PojkeDoKsiegowania { get; set; }

    public decimal PojkeDoKsiegowaniaRos { get; set; }

    public string PojkeOpis { get; set; } = null!;

    public string PojkeUwagi { get; set; } = null!;

    public virtual ICollection<PojKosztyEksploatacjiWpi> PojKosztyEksploatacjiWpis { get; set; } = new List<PojKosztyEksploatacjiWpi>();

    public virtual SlKategorium? PojkeIdKategoriiNavigation { get; set; }
}
