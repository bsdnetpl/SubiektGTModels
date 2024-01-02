using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKursBhp
{
    public int KbhpId { get; set; }

    public string KbhpNazwa { get; set; } = null!;

    public virtual ICollection<PrKursyBhp> PrKursyBhps { get; set; } = new List<PrKursyBhp>();
}
