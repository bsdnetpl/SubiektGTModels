using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklEDeklLog
{
    public int DellId { get; set; }

    public int DellIdeDeklaracji { get; set; }

    public DateTime DellDataWpis { get; set; }

    public string DellWpis { get; set; } = null!;

    public virtual DeklEDekl DellIdeDeklaracjiNavigation { get; set; } = null!;
}
