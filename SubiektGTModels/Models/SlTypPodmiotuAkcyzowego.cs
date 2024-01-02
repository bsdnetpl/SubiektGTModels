using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTypPodmiotuAkcyzowego
{
    public int SltpaId { get; set; }

    public string SltpaWartosc { get; set; } = null!;

    public bool SltpaAktywna { get; set; }
}
