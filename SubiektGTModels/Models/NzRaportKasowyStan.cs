using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzRaportKasowyStan
{
    public int RksId { get; set; }

    public int RksIdRaportu { get; set; }

    public string RksWaluta { get; set; } = null!;

    public decimal RksStanPoczatkowy { get; set; }

    public decimal RksSaldo { get; set; }

    public virtual NzRaportKasowy RksIdRaportuNavigation { get; set; } = null!;

    public virtual SlWalutum RksWalutaNavigation { get; set; } = null!;
}
