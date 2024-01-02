using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbPrzedrostekHist
{
    public int HbpId { get; set; }

    public string HbpPrzedrostek { get; set; } = null!;

    public int HbpIdUslugi { get; set; }

    public virtual ICollection<HbIdent> HbIdents { get; set; } = new List<HbIdent>();

    public virtual ICollection<HbTransakcjaOczekujaca> HbTransakcjaOczekujacas { get; set; } = new List<HbTransakcjaOczekujaca>();

    public virtual HbUsluga HbpIdUslugiNavigation { get; set; } = null!;
}
