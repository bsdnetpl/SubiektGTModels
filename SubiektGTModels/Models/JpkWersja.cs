using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class JpkWersja
{
    public int JpkwId { get; set; }

    public string JpkwNazwa { get; set; } = null!;

    public int JpkwTyp { get; set; }

    public string JpkwNrWersjiOryg { get; set; } = null!;

    public int JpkwNrWersji { get; set; }

    public DateTime? JpkwWaznaOd { get; set; }

    public DateTime? JpkwWaznaDo { get; set; }

    public int JpkwWariantFormularza { get; set; }

    public string? JpkwOpis { get; set; }

    public virtual ICollection<JpkPlik> JpkPliks { get; set; } = new List<JpkPlik>();

    public virtual ICollection<JpkPolaNiestandardowe> JpkPolaNiestandardowes { get; set; } = new List<JpkPolaNiestandardowe>();

    public virtual JpkTyp JpkwTypNavigation { get; set; } = null!;
}
