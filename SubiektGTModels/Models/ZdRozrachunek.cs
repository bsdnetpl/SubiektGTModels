using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdRozrachunek
{
    public int ZdrId { get; set; }

    public int ZdrIdZadania { get; set; }

    public int ZdrIdRozrachunku { get; set; }

    public virtual NzFinanse ZdrIdRozrachunkuNavigation { get; set; } = null!;

    public virtual ZdZadanie ZdrIdZadaniaNavigation { get; set; } = null!;
}
