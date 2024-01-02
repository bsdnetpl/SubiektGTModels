using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdBlokadaObiekt
{
    public int BloId { get; set; }

    public int BloParamEwidId { get; set; }

    public int BloTyp { get; set; }

    public int BloOffset { get; set; }

    public DateTime? BloDataQuattro { get; set; }

    public int BloTypObiektu { get; set; }

    public int BloTypObiektuEx { get; set; }

    public DateTime? BloData { get; set; }

    public DateTime? BloDataRew { get; set; }

    public virtual PdBlokadum BloParamEwid { get; set; } = null!;
}
