using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklPoleViudo
{
    public int DpvId { get; set; }

    public int DpvIdDeklaracji { get; set; }

    public int DpvTypPola { get; set; }

    public string DpvNazwaPola { get; set; } = null!;

    public string DpvWartosc { get; set; } = null!;

    public string DpvNazwaPolaPowiazanego { get; set; } = null!;

    public string DpvNazwaSekcji { get; set; } = null!;

    public string DpvLicznik { get; set; } = null!;

    public bool DpvCzyWymagane { get; set; }

    public virtual DeklEwid DpvIdDeklaracjiNavigation { get; set; } = null!;
}
