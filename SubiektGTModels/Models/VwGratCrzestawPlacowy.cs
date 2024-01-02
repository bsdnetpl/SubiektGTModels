using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrzestawPlacowy
{
    public int ZpId { get; set; }

    public string ZpNazwa { get; set; } = null!;

    public string ZpOpis { get; set; } = null!;

    public bool ZpRozliczacEcp { get; set; }

    public bool ZpRozliczacNadgodziny { get; set; }

    public bool ZpRozliczacAkordy { get; set; }

    public bool ZpRozliczacProwizje { get; set; }

    public bool ZpRozliczacNalPot { get; set; }

    public bool ZpRozliczacPkzp { get; set; }

    public bool ZpStyczen { get; set; }

    public bool ZpLuty { get; set; }

    public bool ZpMarzec { get; set; }

    public bool ZpKwiecien { get; set; }

    public bool ZpMaj { get; set; }

    public bool ZpCzerwiec { get; set; }

    public bool ZpLipiec { get; set; }

    public bool ZpSierpien { get; set; }

    public bool ZpWrzesien { get; set; }

    public bool ZpPazdzienik { get; set; }

    public bool ZpListopad { get; set; }

    public bool ZpGrudzien { get; set; }

    public bool ZpUzupelnienieDoMinimalnej { get; set; }

    public string? LpNazwa { get; set; }

    public string? LpOpis { get; set; }
}
