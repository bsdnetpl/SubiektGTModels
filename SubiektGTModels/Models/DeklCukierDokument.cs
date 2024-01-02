using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklCukierDokument
{
    public int DcdId { get; set; }

    public int DcdIdDeklaracji { get; set; }

    public int DcdLpFaktury { get; set; }

    public string DcdNrFaktury { get; set; } = null!;

    public DateTime DcdDataFaktury { get; set; }

    public string DcdNipdostawcy { get; set; } = null!;

    public string DcdNipnabywcy { get; set; } = null!;

    public int? DcdIdDokumentuZrodlowego { get; set; }

    public virtual DeklEwid DcdIdDeklaracjiNavigation { get; set; } = null!;
}
