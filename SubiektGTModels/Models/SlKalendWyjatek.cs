using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKalendWyjatek
{
    public int SlwId { get; set; }

    public int SlwIdKalend { get; set; }

    public int? SlwIdAtrybut { get; set; }

    public DateTime SlwData { get; set; }

    public string SlwNazwa { get; set; } = null!;

    public int SlwRodzaj { get; set; }

    public int? SlwIleDzienne { get; set; }

    public int? SlwIleNocne { get; set; }

    public bool SlwUstawowy { get; set; }

    public int? SlwGodzinyPracyOd { get; set; }

    public int? SlwTypDniaWolnego { get; set; }

    public int SlwTypPracy { get; set; }

    public virtual SlKalendarz SlwIdKalendNavigation { get; set; } = null!;

    public virtual SlTypDniaWolnego? SlwTypDniaWolnegoNavigation { get; set; }
}
