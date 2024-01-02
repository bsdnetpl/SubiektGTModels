using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdParametr
{
    public int PdpId { get; set; }

    public bool PdpArchPytaj { get; set; }

    public bool PdpArchNaZakoncz { get; set; }

    public bool PdpArchOkresowa { get; set; }

    public int? PdpArchInterwal { get; set; }

    public bool PdpArchNaWybrKomp { get; set; }

    public string? PdpArchKomputer { get; set; }

    public bool PdpArchPokazUst { get; set; }

    public DateTime? PdpArchDataOst { get; set; }

    public string? PdpArchUzytkOst { get; set; }

    public int PdpCzasBlok { get; set; }
}
