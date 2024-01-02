using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EcpObecnoscPrzedKorektum
{
    public int EcpopkId { get; set; }

    public int EcpopkIdZapis { get; set; }

    public int? EcpopkIdAtrybut { get; set; }

    public int EcpopkZwykleDzienne { get; set; }

    public int EcpopkZwykleNocne { get; set; }

    public int EcpopkNadlPlatne { get; set; }

    public int EcpopkNadlPlatneNocne { get; set; }

    public int EcpopkNadlRozlicz { get; set; }

    public int EcpopkAbsPotrac { get; set; }

    public int EcpopkAbsRozlicz { get; set; }

    public bool EcpopkAbsRozlBezWnPrac { get; set; }

    public bool EcpopkPracaZdalnaOkazjonalna { get; set; }
}
