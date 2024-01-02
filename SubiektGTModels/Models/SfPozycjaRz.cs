using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SfPozycjaRz
{
    public int SfrpId { get; set; }

    public int SfrpIdRzs { get; set; }

    public int SfrpNrPola { get; set; }

    public decimal SfrpWartosc { get; set; }

    public decimal SfrpWartoscPoprzedniego { get; set; }

    public string SfrpOpis { get; set; } = null!;

    public virtual SfRz SfrpIdRzsNavigation { get; set; } = null!;
}
