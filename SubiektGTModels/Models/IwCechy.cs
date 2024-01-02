using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IwCechy
{
    public int IwcId { get; set; }

    public int IwcIdCechy { get; set; }

    public int IwcDoIwId { get; set; }

    public virtual IwDokument IwcDoIw { get; set; } = null!;

    public virtual SlCechaTw IwcIdCechyNavigation { get; set; } = null!;
}
