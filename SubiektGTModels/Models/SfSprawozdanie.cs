using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SfSprawozdanie
{
    public int SfId { get; set; }

    public int SfTyp { get; set; }

    public string SfNazwa { get; set; } = null!;

    public string SfProgId { get; set; } = null!;

    public bool SfDomyslny { get; set; }

    public int SfKolumnyEtykiet { get; set; }

    public int SfKolumnyWartosci { get; set; }

    public string? SfPrefix { get; set; }

    public byte[]? SfTresc { get; set; }

    public int SfUproszczone { get; set; }

    public string? SfOpis { get; set; }

    public int? SfEsfTypZrodla { get; set; }

    public string? SfOpisEn { get; set; }

    public string? SfOpisDe { get; set; }

    public bool SfArchiwalne { get; set; }

    public DateTime? SfDataUzycia { get; set; }

    public virtual ICollection<PdRokObrotowy> PdRokObrotowyRobrWariantPpNavigations { get; set; } = new List<PdRokObrotowy>();

    public virtual ICollection<PdRokObrotowy> PdRokObrotowyRobrWariantRzsNavigations { get; set; } = new List<PdRokObrotowy>();

    public virtual ICollection<SfPole> SfPoles { get; set; } = new List<SfPole>();

    public virtual ICollection<SfRz> SfRzs { get; set; } = new List<SfRz>();

    public virtual ICollection<PdRokObrotowy> SfsnIdRokuObrotowegos { get; set; } = new List<PdRokObrotowy>();
}
