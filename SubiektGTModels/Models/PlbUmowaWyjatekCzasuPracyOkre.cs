using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaWyjatekCzasuPracyOkre
{
    public int UwgId { get; set; }

    public int UwgIdWyj { get; set; }

    public int UwgPoraDnia { get; set; }

    public int UwgOd { get; set; }

    public int UwgDo { get; set; }

    public int? UwgIdAtrybutuGodzin { get; set; }

    public virtual SlAtrybutGodzinowy? UwgIdAtrybutuGodzinNavigation { get; set; }
}
