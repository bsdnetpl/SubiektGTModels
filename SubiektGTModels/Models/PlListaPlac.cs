using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlListaPlac
{
    public int LpId { get; set; }

    public string LpTytul { get; set; } = null!;

    public string LpNumer { get; set; } = null!;

    public DateTime LpData { get; set; }

    public DateTime LpDataWyplaty { get; set; }

    public DateTime LpDataZus { get; set; }

    public int LpStatusImportu { get; set; }

    public bool LpZatwierdzona { get; set; }

    public int? LpIdKategorii { get; set; }

    public bool LpGlowna { get; set; }

    public int LpStatusImportuSkladek { get; set; }

    public int LpRokPrzychodu { get; set; }

    public DateTime LpDataWplatyPpk { get; set; }

    public int LpStatusImportuPpk { get; set; }

    public virtual SlKategorium? LpIdKategoriiNavigation { get; set; }

    public virtual ICollection<PlWyplatum> PlWyplata { get; set; } = new List<PlWyplatum>();
}
