using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbSzablonZp
{
    public int ZplId { get; set; }

    public string ZplNazwa { get; set; } = null!;

    public string ZplOpis { get; set; } = null!;

    public bool ZplRozliczacEcp { get; set; }

    public bool ZplRozliczacNadgodziny { get; set; }

    public bool ZplRozliczacAkordy { get; set; }

    public bool ZplRozliczacProwizje { get; set; }

    public bool ZplRozliczacNaliczeniaPotracenia { get; set; }

    public bool ZplRozliczacPotraceniaKomornicze { get; set; }

    public int? ZplIdSzablonuListPlac { get; set; }

    public bool ZplMcWyplacania1 { get; set; }

    public bool ZplMcWyplacania2 { get; set; }

    public bool ZplMcWyplacania3 { get; set; }

    public bool ZplMcWyplacania4 { get; set; }

    public bool ZplMcWyplacania5 { get; set; }

    public bool ZplMcWyplacania6 { get; set; }

    public bool ZplMcWyplacania7 { get; set; }

    public bool ZplMcWyplacania8 { get; set; }

    public bool ZplMcWyplacania9 { get; set; }

    public bool ZplMcWyplacania10 { get; set; }

    public bool ZplMcWyplacania11 { get; set; }

    public bool ZplMcWyplacania12 { get; set; }

    public bool ZplUzupelniacDoMinimalnej { get; set; }

    public virtual ICollection<PlbSzablonZpskladnik> PlbSzablonZpskladniks { get; set; } = new List<PlbSzablonZpskladnik>();
}
