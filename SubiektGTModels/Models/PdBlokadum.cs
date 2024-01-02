using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdBlokadum
{
    public int BlId { get; set; }

    public DateTime? BlBlokadaSubiekt { get; set; }

    public DateTime? BlBlokadaRew { get; set; }

    public int BlParamEwidId { get; set; }

    public int BlTyp { get; set; }

    public int BlOffset { get; set; }

    public DateTime? BlDataQuattro { get; set; }

    public virtual ParEwid BlParamEwid { get; set; } = null!;

    public virtual ICollection<PdBlokadaObiekt> PdBlokadaObiekts { get; set; } = new List<PdBlokadaObiekt>();
}
