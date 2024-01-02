using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EcpGodzina
{
    public int EcpgId { get; set; }

    public int EcpgIdZapis { get; set; }

    public int EcpgPoraDnia { get; set; }

    public int EcpgOd { get; set; }

    public int EcpgDo { get; set; }

    public int? EcpgIdAtrybutuGodzin { get; set; }

    public virtual SlAtrybutGodzinowy? EcpgIdAtrybutuGodzinNavigation { get; set; }

    public virtual EcpZapi EcpgIdZapisNavigation { get; set; } = null!;
}
