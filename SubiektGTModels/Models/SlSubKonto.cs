using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlSubKonto
{
    public int SkId { get; set; }

    public int SkIdFormaPlatnosci { get; set; }

    public string SkNazwa { get; set; } = null!;

    public int SkIdParser { get; set; }

    public virtual SlFormaPlatnosci SkIdFormaPlatnosciNavigation { get; set; } = null!;
}
