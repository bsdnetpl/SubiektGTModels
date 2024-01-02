using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlGrupaTw
{
    public int GrtId { get; set; }

    public string GrtNazwa { get; set; } = null!;

    public string? GrtNrAnalityka { get; set; }

    public virtual ICollection<CenCennikGrupa> CenCennikGrupas { get; set; } = new List<CenCennikGrupa>();

    public virtual ICollection<IwGrupy> IwGrupies { get; set; } = new List<IwGrupy>();

    public virtual ICollection<TwTowar> TwTowars { get; set; } = new List<TwTowar>();
}
