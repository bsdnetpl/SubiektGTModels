using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class JpkTyp
{
    public int JpktId { get; set; }

    public string JpktNazwa { get; set; } = null!;

    public int JpktProgramy { get; set; }

    public int JpktKolejnosc { get; set; }

    public virtual ICollection<JpkPlik> JpkPliks { get; set; } = new List<JpkPlik>();

    public virtual ICollection<JpkWersja> JpkWersjas { get; set; } = new List<JpkWersja>();
}
