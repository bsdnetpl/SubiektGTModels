using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklPole
{
    public int DpId { get; set; }

    public int DpIdDeklaracji { get; set; }

    public int DpNrPola { get; set; }

    public bool DpZmienione { get; set; }

    public string? DpWartosc { get; set; }

    public int? DpKolejnosc { get; set; }

    public int? DpGrupaWartNal { get; set; }

    public int? DpTypWartNal { get; set; }

    public bool DpUkryte { get; set; }

    public virtual DeklEwid DpIdDeklaracjiNavigation { get; set; } = null!;
}
