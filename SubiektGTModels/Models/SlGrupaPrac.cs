using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlGrupaPrac
{
    public int GrpId { get; set; }

    public string GrpNazwa { get; set; } = null!;

    public virtual ICollection<PrPracownik> PrPracowniks { get; set; } = new List<PrPracownik>();
}
