using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKalendWyjGodzina
{
    public int SlwgId { get; set; }

    public int SlwgIdWyj { get; set; }

    public int SlwgPoraDnia { get; set; }

    public int SlwgOd { get; set; }

    public int SlwgDo { get; set; }

    public int? SlwgIdAtrybutuGodzin { get; set; }

    public virtual SlAtrybutGodzinowy? SlwgIdAtrybutuGodzinNavigation { get; set; }
}
