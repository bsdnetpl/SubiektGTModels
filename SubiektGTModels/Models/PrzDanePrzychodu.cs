using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrzDanePrzychodu
{
    public int PrzdId { get; set; }

    public int PrzdIdPrzychodu { get; set; }

    public int PrzdIdStawkiRyczaltu { get; set; }

    public decimal PrzdWartosc { get; set; }

    public virtual PrzPrzychod PrzdIdPrzychoduNavigation { get; set; } = null!;

    public virtual PrzStawkaRyczaltu PrzdIdStawkiRyczaltuNavigation { get; set; } = null!;
}
