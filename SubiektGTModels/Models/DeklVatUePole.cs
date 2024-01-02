using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklVatUePole
{
    public int DuepId { get; set; }

    public int DuepIdDeklaracji { get; set; }

    public int DuepTyp { get; set; }

    public string DuepPanstwo { get; set; } = null!;

    public string DuepNip { get; set; } = null!;

    public decimal? DuepWartosc { get; set; }

    public bool DuepTt { get; set; }

    public int DuepByloJest { get; set; }

    public int DuepPozycja { get; set; }

    public string? DuepNazwa { get; set; }

    public virtual DeklEwid DuepIdDeklaracjiNavigation { get; set; } = null!;
}
