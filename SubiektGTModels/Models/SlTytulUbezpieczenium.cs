using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTytulUbezpieczenium
{
    public int TuId { get; set; }

    public string TuKod { get; set; } = null!;

    public string TuOpis { get; set; } = null!;

    public virtual ICollection<PdWspolnik> PdWspolniks { get; set; } = new List<PdWspolnik>();

    public virtual ICollection<PlUmowaCp> PlUmowaCps { get; set; } = new List<PlUmowaCp>();

    public virtual ICollection<PlUmowaOprace> PlUmowaOpraces { get; set; } = new List<PlUmowaOprace>();

    public virtual ICollection<PlbUmowaCpParametryZestaw> PlbUmowaCpParametryZestaws { get; set; } = new List<PlbUmowaCpParametryZestaw>();

    public virtual ICollection<PlbUmowaCp> PlbUmowaCps { get; set; } = new List<PlbUmowaCp>();
}
