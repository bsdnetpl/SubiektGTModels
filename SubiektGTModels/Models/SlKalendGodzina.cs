using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKalendGodzina
{
    public int SlgId { get; set; }

    public int SlgIdDzien { get; set; }

    public int SlgPoraDnia { get; set; }

    public int SlgOd { get; set; }

    public int SlgDo { get; set; }

    public int? SlgIdAtrybutuGodzin { get; set; }

    public virtual SlAtrybutGodzinowy? SlgIdAtrybutuGodzinNavigation { get; set; }
}
