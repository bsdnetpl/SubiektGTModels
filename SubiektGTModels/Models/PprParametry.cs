using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PprParametry
{
    public int PprpId { get; set; }

    public int PprpGodzNocneOd { get; set; }

    public int PprpGodzNocneDo { get; set; }

    public int PprpDomyslnyOkresOd { get; set; }

    public int PprpDomyslnyOkresDo { get; set; }

    public bool PprpZerujGodzinyBezPlanu { get; set; }

    public bool PprpNadpisujWyjatkiPlan { get; set; }

    public bool PprpNadpisujAbsencjePlan { get; set; }

    public bool PprpNadpisujGodzinyPlan { get; set; }

    public bool PprpNadpisujGodzinyWykonanie { get; set; }
}
