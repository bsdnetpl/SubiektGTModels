using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCechaTw
{
    public int CtwId { get; set; }

    public string CtwNazwa { get; set; } = null!;

    public virtual ICollection<CenCennikCecha> CenCennikCechas { get; set; } = new List<CenCennikCecha>();

    public virtual ICollection<IwCechy> IwCechies { get; set; } = new List<IwCechy>();

    public virtual SlWlasciwoscCecha? SlWlasciwoscCecha { get; set; }

    public virtual ICollection<TwCechaTw> TwCechaTws { get; set; } = new List<TwCechaTw>();
}
