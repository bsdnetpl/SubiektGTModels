using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PprPlanPracy
{
    public int PprId { get; set; }

    public string PprNazwa { get; set; } = null!;

    public int PprIdPrac { get; set; }

    public DateTime PprPoczatek { get; set; }

    public DateTime PprKoniec { get; set; }

    public int PprKolor { get; set; }

    public string PprUwagi { get; set; } = null!;

    public string PprOpis { get; set; } = null!;

    public int PprTyp { get; set; }

    public bool PprPlanowanie { get; set; }

    public virtual PprAbsencja? PprAbsencja { get; set; }

    public virtual PrPracownik PprIdPracNavigation { get; set; } = null!;

    public virtual PprObecnosc? PprObecnosc { get; set; }
}
