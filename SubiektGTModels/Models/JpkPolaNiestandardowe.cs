using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class JpkPolaNiestandardowe
{
    public int JpknId { get; set; }

    public int JpknWersja { get; set; }

    public string JpknNazwa { get; set; } = null!;

    public int JpknTypPola { get; set; }

    public string JpknDef { get; set; } = null!;

    public string JpknRodzic { get; set; } = null!;

    public virtual JpkWersja JpknWersjaNavigation { get; set; } = null!;
}
