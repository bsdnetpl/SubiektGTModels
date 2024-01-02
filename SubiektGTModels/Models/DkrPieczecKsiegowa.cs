using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrPieczecKsiegowa
{
    public int DkpkId { get; set; }

    public string DkpkNazwa { get; set; } = null!;

    public int DkpkKontrolaBilansowania { get; set; }

    public virtual ICollection<DkrPieczecKsiegowaPozycja> DkrPieczecKsiegowaPozycjas { get; set; } = new List<DkrPieczecKsiegowaPozycja>();
}
