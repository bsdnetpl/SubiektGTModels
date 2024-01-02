using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrPpk
{
    public int PpkId { get; set; }

    public int PpkIdPrac { get; set; }

    public bool PpkUczestnictwo { get; set; }

    public DateTime? PpkMiesiacZgloszeniaDoIf { get; set; }

    public DateTime? PpkNaliczajWplatyOd { get; set; }

    public string? PpkNrEwidencyjny { get; set; }

    public int? PpkIdDeklaracji { get; set; }

    public decimal PpkWplataPodstawowaPracownika { get; set; }

    public decimal PpkWplataDodatkowaPracownika { get; set; }

    public decimal PpkWplataDodatkowaPracodawcy { get; set; }

    public virtual DeklEwid? PpkIdDeklaracjiNavigation { get; set; }

    public virtual PrPracownik PpkIdPracNavigation { get; set; } = null!;
}
