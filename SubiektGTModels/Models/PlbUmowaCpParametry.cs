using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaCpParametry
{
    public int UpId { get; set; }

    public string UpNazwa { get; set; } = null!;

    public virtual ICollection<PlbUmowaCpParametryZestaw> PlbUmowaCpParametryZestaws { get; set; } = new List<PlbUmowaCpParametryZestaw>();
}
