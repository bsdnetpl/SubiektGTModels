using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FlFlagi
{
    public int FlgId { get; set; }

    public int FlgNumer { get; set; }

    public string FlgText { get; set; } = null!;

    public int FlgIdGrupy { get; set; }

    public bool FlgDomyslna { get; set; }

    public string FlgDomyslnyKomentarz { get; set; } = null!;

    public int? FlgIdUprNadaj { get; set; }

    public int? FlgIdUprZdejmij { get; set; }

    public virtual ICollection<EmRule> EmRules { get; set; } = new List<EmRule>();

    public virtual ICollection<FlWartosc> FlWartoscs { get; set; } = new List<FlWartosc>();

    public virtual FlGrupy FlgIdGrupyNavigation { get; set; } = null!;

    public virtual ICollection<IwFlagi> IwFlagis { get; set; } = new List<IwFlagi>();
}
