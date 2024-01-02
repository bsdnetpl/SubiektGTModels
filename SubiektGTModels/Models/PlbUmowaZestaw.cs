using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaZestaw
{
    public int UpzId { get; set; }

    public int UpzIdUmowy { get; set; }

    public int? UpzIdSzablonuLp { get; set; }

    public string UpzNazwa { get; set; } = null!;

    public string UpzOpis { get; set; } = null!;

    public bool UpzRozliczacEcp { get; set; }

    public bool UpzRozliczacNadgodziny { get; set; }

    public bool UpzRozliczacAkordy { get; set; }

    public bool UpzRozliczacProwizje { get; set; }

    public bool UpzRozliczacNaliczeniaPotracenia { get; set; }

    public bool UpzRozliczacPotraceniaKomornicze { get; set; }

    public bool UpzMcWyplacania1 { get; set; }

    public bool UpzMcWyplacania2 { get; set; }

    public bool UpzMcWyplacania3 { get; set; }

    public bool UpzMcWyplacania4 { get; set; }

    public bool UpzMcWyplacania5 { get; set; }

    public bool UpzMcWyplacania6 { get; set; }

    public bool UpzMcWyplacania7 { get; set; }

    public bool UpzMcWyplacania8 { get; set; }

    public bool UpzMcWyplacania9 { get; set; }

    public bool UpzMcWyplacania10 { get; set; }

    public bool UpzMcWyplacania11 { get; set; }

    public bool UpzMcWyplacania12 { get; set; }

    public bool UpzUzupelniacDoMinimalnej { get; set; }

    public virtual PlbSzablonLp? UpzIdSzablonuLpNavigation { get; set; }

    public virtual PlbUmowa UpzIdUmowyNavigation { get; set; } = null!;
}
