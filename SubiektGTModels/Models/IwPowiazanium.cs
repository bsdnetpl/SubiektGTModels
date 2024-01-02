using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IwPowiazanium
{
    public int IwaId { get; set; }

    public int IwaIdCz { get; set; }

    public int IwaIdZb { get; set; }

    public virtual IwDokument IwaIdCzNavigation { get; set; } = null!;

    public virtual IwDokument IwaIdZbNavigation { get; set; } = null!;
}
