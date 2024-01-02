using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FlGrupy
{
    public int FlpId { get; set; }

    public string FlpNazwa { get; set; } = null!;

    public virtual ICollection<FlFlagi> FlFlagis { get; set; } = new List<FlFlagi>();

    public virtual ICollection<FlWartosc> FlWartoscs { get; set; } = new List<FlWartosc>();
}
