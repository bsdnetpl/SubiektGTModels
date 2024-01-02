using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklJpkV7pole
{
    public int JvpId { get; set; }

    public int JvpIdDeklaracji { get; set; }

    public string? JvpNip { get; set; }

    public int? JvpTypPodmiotu { get; set; }

    public string? JvpNazwaPodmiotu { get; set; }

    public virtual DeklEwid JvpIdDeklaracjiNavigation { get; set; } = null!;
}
