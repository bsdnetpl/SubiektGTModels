using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfTransmisjaKontekst
{
    public int UtkId { get; set; }

    public int UtkIdTransmisjaSzczegol { get; set; }

    public int UtkTyp { get; set; }

    public int UtkParametr1 { get; set; }

    public int UtkParametr2 { get; set; }

    public virtual UfTransmisjaSzczegol UtkIdTransmisjaSzczegolNavigation { get; set; } = null!;
}
