using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlGratPrzyczynaRozwUmowy
{
    public int GpruId { get; set; }

    public string GpruNazwa { get; set; } = null!;

    public string GpruKod { get; set; } = null!;

    public virtual ICollection<PlbUmowaCp> PlbUmowaCps { get; set; } = new List<PlbUmowaCp>();

    public virtual ICollection<PlbUmowa> PlbUmowas { get; set; } = new List<PlbUmowa>();

    public virtual ICollection<PrZatrudnienie> PrZatrudnienies { get; set; } = new List<PrZatrudnienie>();
}
