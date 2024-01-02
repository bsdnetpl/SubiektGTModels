using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdUzytkownikOddzial
{
    public int PduoId { get; set; }

    public int PduoIdUzytkownik { get; set; }

    public int PduoIdOddzial { get; set; }

    public virtual SlOddzialy PduoIdOddzialNavigation { get; set; } = null!;

    public virtual PdUzytkownik PduoIdUzytkownikNavigation { get; set; } = null!;
}
