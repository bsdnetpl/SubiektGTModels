using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlUrzadSkarbowy
{
    public int SusId { get; set; }

    public string SusKod { get; set; } = null!;

    public string SusOpis { get; set; } = null!;

    public virtual ICollection<IsInstytucja> IsInstytucjas { get; set; } = new List<IsInstytucja>();

    public virtual ICollection<JpkPaczka> JpkPaczkas { get; set; } = new List<JpkPaczka>();

    public virtual ICollection<JpkPlik> JpkPliks { get; set; } = new List<JpkPlik>();
}
