using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EcpObecnosc
{
    public int EcpoId { get; set; }

    public int EcpoIdZapis { get; set; }

    public int? EcpoIdAtrybut { get; set; }

    public int EcpoZwykleDzienne { get; set; }

    public int EcpoZwykleNocne { get; set; }

    public int EcpoNadlPlatne { get; set; }

    public int EcpoNadlPlatneNocne { get; set; }

    public int EcpoNadlRozlicz { get; set; }

    public int EcpoAbsPotrac { get; set; }

    public int EcpoAbsRozlicz { get; set; }

    public bool EcpoAbsRozlBezWnPrac { get; set; }

    public int EcpoAbsOpiekaNadDzieckiem { get; set; }

    public bool EcpoPracaZdalnaOkazjonalna { get; set; }

    public virtual EcpZapi EcpoIdZapisNavigation { get; set; } = null!;
}
